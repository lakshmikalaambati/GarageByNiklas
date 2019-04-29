using System;
using System.Configuration;
using System.Reflection;

namespace MyGarage
{
    internal static class ManagerFactory
    {
        internal static IGarageManager Create(int size)
        {
            var value = ConfigurationManager.AppSettings["Manager"];
            IGarageManager manager = null;

            switch (value)
            {
                case "MyGarage.GarageManager":

                    var type = Assembly.GetExecutingAssembly().GetType(value);
                    manager =  (GarageManager)Activator.CreateInstance(type, size);
                    break;
            }

            return manager ??   null;

        }
    }
}