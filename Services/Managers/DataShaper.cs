using Entities.Models;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Services.Managers
{
    public class DataShaper<T> : IDataShaper<T>
        where T : class
    {
        public PropertyInfo[] Properties{ get; set; }
        public DataShaper()
        {
            Properties = typeof(T)
                .GetProperties(BindingFlags.Public | BindingFlags.Instance);
        }
        public IEnumerable<ShapedEntity> ShapeData(IEnumerable<T> entities, string fieldString)
        {
            var requiredProp = GetRequiredProperties(fieldString);
            return FetchData(entities, requiredProp);
        }

        public ShapedEntity ShapeData(T entity, string fieldString)
        {
            var requiredProp = GetRequiredProperties(fieldString);
            return FetchDataForEntity(entity, requiredProp);
        }
        private IEnumerable<PropertyInfo> GetRequiredProperties(string fieldsString)
        {
            var requiredFields = new List<PropertyInfo>();
            if(!string.IsNullOrWhiteSpace(fieldsString))
            {
                var fields = fieldsString.Split(',',StringSplitOptions.RemoveEmptyEntries);
                foreach (var field in fields)
                {
                    var property = Properties
                        .FirstOrDefault(pi => pi.Name.Equals(field.Trim(), StringComparison.InvariantCultureIgnoreCase));
                    if (property is null) continue;

                    requiredFields.Add(property);
                }
            }
            else
            {
                requiredFields = Properties.ToList();
            }
            return requiredFields;
        }

        private ShapedEntity FetchDataForEntity(T entity,IEnumerable<PropertyInfo> requiredProperties)
        {
            var shapeObject = new ShapedEntity();
            foreach (var property in requiredProperties)
            {
                var objectPropertyValue = property.GetValue(entity);
                shapeObject.Entity.TryAdd(property.Name, objectPropertyValue);
            }
            var objectProperty = entity.GetType().GetProperty("Id");
            shapeObject.Id = (int)objectProperty.GetValue(entity);
                return shapeObject;
        }

        private IEnumerable<ShapedEntity> FetchData(IEnumerable<T> entities,IEnumerable<PropertyInfo> requiredProperties)
        {
            var shapeData = new List<ShapedEntity>();
            foreach (var entity in entities)
            {
                var shapedObject = FetchDataForEntity(entity, requiredProperties);
                shapeData.Add(shapedObject);
            }
            return shapeData;
        }
    }
}
