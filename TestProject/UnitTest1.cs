using System.ComponentModel.DataAnnotations;
using System.Reflection;
using dotnetapp.Controllers;
using dotnetapp.Models;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        
        [Test]
        public void S1_Model_Class_Book_Exists()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Models.Book";
            Assembly assembly = Assembly.Load(assemblyName);
            Type playerType = assembly.GetType(typeName);
            Assert.IsNotNull(playerType);
        }

        [Test]
        public void S1_Model_Class_Category_Exists()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Models.Category";
            Assembly assembly = Assembly.Load(assemblyName);
            Type playerType = assembly.GetType(typeName);
            Assert.IsNotNull(playerType);
        }

        [Test]
        public void S1_Model_Class_ShoppingCart_Exists()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Models.ShoppingCart";
            Assembly assembly = Assembly.Load(assemblyName);
            Type playerType = assembly.GetType(typeName);
            Assert.IsNotNull(playerType);
        }

        [Test]
        public void S1_Model_Class_ShoppingCartItem_Exists()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Models.ShoppingCartItem";
            Assembly assembly = Assembly.Load(assemblyName);
            Type playerType = assembly.GetType(typeName);
            Assert.IsNotNull(playerType);
        }
        [Test]
        public void S1_Test_DetailsViewFile_Exists()
        {
            string indexPath = Path.Combine(@"/home/coder/project/workspace/dotnetapp/Views/Book/", "Details.cshtml");
            bool indexViewExists = File.Exists(indexPath);

            Assert.IsTrue(indexViewExists, "Details.cshtml view file does not exist.");
        }

        [Test]
        public void S1_Test_IndexViewFile_Exists()
        {
            string indexPath = Path.Combine(@"/home/coder/project/workspace/dotnetapp/Views/Category/", "Index.cshtml");
            bool indexViewExists = File.Exists(indexPath);

            Assert.IsTrue(indexViewExists, "Details.cshtml view file does not exist.");
        }

        [Test]
        public void S3_Book_Properties_Have_RequiredAttribute_Title()
        {
            var count = 0;
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Models.Book";
            Assembly assembly = Assembly.Load(assemblyName);
            Type employeeType = assembly.GetType(typeName);

            //Type employeeType = typeof(dotnetapp.Models.Book);
            PropertyInfo[] properties = employeeType.GetProperties();

            foreach (var property in properties)
            {
                if (property.Name == "Title")
                {
                    var requiredAttribute = property.GetCustomAttribute<RequiredAttribute>();
                    Assert.NotNull(requiredAttribute, $"{property.Name} should have a RequiredAttribute.");
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void S3_Book_Properties_Have_RequiredAttribute_Author()
        {
            var count = 0;
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Models.Book";
            Assembly assembly = Assembly.Load(assemblyName);
            Type employeeType = assembly.GetType(typeName);

            //Type employeeType = typeof(dotnetapp.Models.Book);
            PropertyInfo[] properties = employeeType.GetProperties();

            foreach (var property in properties)
            {
                if (property.Name == "Author")
                {
                    var requiredAttribute = property.GetCustomAttribute<RequiredAttribute>();
                    Assert.NotNull(requiredAttribute, $"{property.Name} should have a RequiredAttribute.");
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void S3_Book_Properties_Have_RangeAttribute_Price()
        {
            var count = 0;
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Models.Book";
            Assembly assembly = Assembly.Load(assemblyName);
            Type employeeType = assembly.GetType(typeName);
            PropertyInfo[] properties = employeeType.GetProperties();

            foreach (var property in properties)
            {
                if (property.Name == "Price")
                {
                    var rangeAttribute = property.GetCustomAttribute<System.ComponentModel.DataAnnotations.RangeAttribute>();
                    Assert.NotNull(rangeAttribute, $"{property.Name} should have a RangeAttribute.");
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void S3_ShoppingCartItem_Properties_Have_RangeAttribute_Quantity()
        {
            var count = 0;
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Models.ShoppingCartItem";
            Assembly assembly = Assembly.Load(assemblyName);
            Type employeeType = assembly.GetType(typeName);
            PropertyInfo[] properties = employeeType.GetProperties();

            foreach (var property in properties)
            {
                if (property.Name == "Quantity")
                {
                    var rangeAttribute = property.GetCustomAttribute<System.ComponentModel.DataAnnotations.RangeAttribute>();
                    Assert.NotNull(rangeAttribute, $"{property.Name} should have a RangeAttribute.");
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                Assert.Fail();
            }
        }

    }
}