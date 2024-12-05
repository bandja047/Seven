using Seven.Models;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Seven.Helpers
{
    public class Mapper
    {
        public static void ConfigMappper(Action<Categorie> CAT)
        {

        }
        public static TTarget Map<TSource, TTarget>(TSource source) where TTarget : new()
        {
            if (source == null)
                throw new ArgumentNullException(nameof(TSource), "L'objet source ne peut etre null");

            if (typeof(TSource).IsGenericType && typeof(TSource).GetGenericTypeDefinition() == typeof(List<>))
            {
                Type targetItemType = typeof(TTarget).GetGenericArguments()[0];

                var targetList = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(targetItemType));

                foreach (var item in (IEnumerable)source)
                {
                    var mappedItem = MapObject(item, targetItemType);
                    targetList.Add(mappedItem);
                }

                return (TTarget)targetList;
            }
            else
            {
                return MapObject<TSource, TTarget>(source);
            }
        }
        private static TTarget MapObject<TSource, TTarget>(TSource source) where TTarget : new()
        {
            if (source == null)
                throw new ArgumentNullException(nameof(TSource), "L'objet source ne peut etre null");

            TTarget target = new TTarget();

            foreach (PropertyInfo sourceProperty in typeof(TSource).GetProperties())
            {
                PropertyInfo targetProperty = typeof(TTarget).GetProperty(sourceProperty.Name);

                if (targetProperty != null && targetProperty.CanWrite)
                {
                    if (targetProperty.PropertyType == sourceProperty.PropertyType)
                    {
                        targetProperty.SetValue(target, sourceProperty.GetValue(source, null), null);

                    }
                    else if (!targetProperty.PropertyType.IsPrimitive && targetProperty.PropertyType != typeof(string))
                    {
                        object nestedSource = sourceProperty.GetValue(source);

                        if (nestedSource != null)
                        {
                            object nestedTarget = MapObject(nestedSource, targetProperty.PropertyType);
                            targetProperty.SetValue(target, nestedTarget);
                        }
                    }

                }
            }

            return target;
        }

        private static object MapObject(object source, Type targetType)
        {
            if (source == null) return null;

            object target = Activator.CreateInstance(targetType);

            foreach (PropertyInfo sourceProperty in source.GetType().GetType().GetProperties())
            {
                PropertyInfo targetProperty = targetType.GetProperty(sourceProperty.Name);

                if (targetProperty != null && sourceProperty.CanWrite)
                {
                    if (targetProperty.PropertyType == sourceProperty.PropertyType)
                    {
                        targetProperty.SetValue(target, sourceProperty.GetValue(source, null), null);

                    }
                    else if (!targetProperty.PropertyType.IsPrimitive && targetProperty.PropertyType != typeof(string))
                    {
                        object nestedSource = sourceProperty.GetValue(source, null);

                        if (nestedSource != null)
                        {

                            object nestedTarget = MapObject(nestedSource, targetProperty.PropertyType);
                            targetProperty.SetValue(target, nestedTarget);

                        }
                    }
                }
            }

            return target;
        }
    }
}
