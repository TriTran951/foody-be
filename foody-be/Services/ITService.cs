using foody_be.Models.Context;
using foody_be.Models.ErdModels;
using foody_be.Services.GenericService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System.ComponentModel;

namespace foody_be.Services
{
    public class ITService : GenericService<User>
    {
        public ITService(MyDbContext context) : base(context)
        {
        }
        public List<Ingredient> addIngredientFromExcel(IFormFile file)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            List<Ingredient> entities = new List<Ingredient>();

            using (var package = new ExcelPackage(file.OpenReadStream()))
            {
                var worksheet = package.Workbook.Worksheets["ingredient"];
                var rowCount = worksheet.Dimension.Rows;

                for (int row = 3; row <= rowCount + 1; row++)
                {
                    var ingredientName = worksheet.Cells[row, 1].Value?.ToString();

                    if (ingredientName == null)
                        continue;
                    if (IngredientValid(ingredientName))
                        continue;
                }
            }
            return new List<Ingredient>();
        }
        protected bool IngredientValid(string name)
        {
            var type = db.Ingredient.FirstOrDefault(e =>  e.name== name);
            if (type != null)
            {
                return true;
            }
            return false;
        }
    }
}
