// ������ ����������� ����������� ����
using _732_1Shifer;
using NUnit.Framework;

// ���������� ������������ ���� ��� ������
namespace TestBD
{
    // ���������� ������ ������
    [TestClass]
    public class UnitTest1
    {
        // ���� ��� ��������, ��� �������������� � ����������� �������� ������� ���������� true
        [TestMethod]
        public void TestAuthUser_CorrectCredentials_ReturnsTrue()
        {
            // Arrange: �������� ���������� ������ DBManager � ��������� ���� � ���� ������
            DBManager dBManager = new DBManager("C:\\BASE\\732SHIFER.db");

            // Act: ����� ������ AuthUser � ����������� �������� �������
            bool result = dBManager.AuthUser("user", "123");

            // Assert: ��������, ��� ��������� ����� true
            NUnit.Framework.Assert.That(result, Is.True);
        }

        // ���� ��� ��������, ��� �������������� � ������������� �������� ������� ���������� false
        [TestMethod]
        public void TestAuthUser_IncorrectCredentials_ReturnsFalse()
        {
            // Arrange: �������� ���������� ������ DBManager � ��������� ���� � ���� ������
            DBManager dBManager = new DBManager("C:\\BASE\\732SHIFER.db");

            // Act: ����� ������ AuthUser � ������������� �������� �������
            bool result = dBManager.AuthUser("fhgfh54564", "34235rtge");

            // Assert: ��������, ��� ��������� ����� false
            NUnit.Framework.Assert.That(result, Is.False);
        }
    }
}
