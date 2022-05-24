using Xunit;
using Cleaning_Service;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void StaffTest()
        {
            Staff staff;

            // Act
            staff = new Staff("Cameron", "Shearer", 'M', "she16003894@btc.ac.uk", "07884942572", "Manager");
            string testStaff = staff.ToString();

            // Assert
            Assert.IsType<Staff>(staff);
            Assert.Equal(testStaff, $"Cameron Shearer M : {staff.Id} - Manager\nContact: she16003894@btc.ac.uk + 07884942572");
        }
        [Fact]
        public void CustomerTest()
        {
            Customer customer;

            // Act
            customer = new Customer("Cameron", "Shearer", 'M', "she16003894@btc.ac.uk", "07884942572", "123 Road", "Bridgwater", "Somerset");
            string testCustomer = customer.ToString();

            // Assert
            Assert.IsType<Customer>(customer);
            Assert.Equal(testCustomer, $"Cameron Shearer M : {customer.Id}\nContact: she16003894@btc.ac.uk + 07884942572\n123 Road, Bridgwater, Somerset");
        }
        [Fact]
        public void BookTest()
        {
            Book book;

            // Act
            book = new Book("456 Road", "Bridgwater", "Somerset", 200, "Seven Rooms", "testOwnerId", "testEmployeeId", "FLAT", "ASDA");
            string testBook = book.ToString();

            // Assert
            Assert.IsType<Book>(book);
            Assert.Equal(testBook, $"Property: ASDA 456 Road Bridgwater Somerset : {book.Id}\nType: FLAT 200\nDate Booked: {book.Date}\nComplete: {book.Complete} at {book.Updated}");
        }
        [Fact]
        public void MaterialTest()
        {
            Material material;

            // Act
            material = new Material("Piping", "Fixing draining system in the Bathroom", 29);
            string testMaterial = material.ToString();

            // Assert
            Assert.IsType<Material>(material);
            Assert.Equal(testMaterial, $"Piping purchased at {material.DatePurchase}\n£29 for Fixing draining system in the Bathroom");

        }
        [Fact]
        public void IssueTest()
        {
            Issue issue;

            // Act
            issue = new Issue("Could not fix draining in the Bathroom");
            string testIssue = issue.ToString();

            Assert.IsType<Issue>(issue);
            Assert.Equal(testIssue, $"Issue - {issue.Id}: Could not fix draining in the Bathroom\nRaised on: {issue.Date}");

        }

    }
}