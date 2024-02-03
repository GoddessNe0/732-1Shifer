// Импорт необходимых пространств имен
using _732_1Shifer;
using NUnit.Framework;

// Объявление пространства имен для тестов
namespace TestBD
{
    // Объявление класса тестов
    [TestClass]
    public class UnitTest1
    {
        // Тест для проверки, что аутентификация с правильными учетными данными возвращает true
        [TestMethod]
        public void TestAuthUser_CorrectCredentials_ReturnsTrue()
        {
            // Arrange: Создание экземпляра класса DBManager с указанием пути к базе данных
            DBManager dBManager = new DBManager("C:\\BASE\\732SHIFER.db");

            // Act: Вызов метода AuthUser с правильными учетными данными
            bool result = dBManager.AuthUser("user", "123");

            // Assert: Проверка, что результат равен true
            NUnit.Framework.Assert.That(result, Is.True);
        }

        // Тест для проверки, что аутентификация с неправильными учетными данными возвращает false
        [TestMethod]
        public void TestAuthUser_IncorrectCredentials_ReturnsFalse()
        {
            // Arrange: Создание экземпляра класса DBManager с указанием пути к базе данных
            DBManager dBManager = new DBManager("C:\\BASE\\732SHIFER.db");

            // Act: Вызов метода AuthUser с неправильными учетными данными
            bool result = dBManager.AuthUser("fhgfh54564", "34235rtge");

            // Assert: Проверка, что результат равен false
            NUnit.Framework.Assert.That(result, Is.False);
        }
    }
}
