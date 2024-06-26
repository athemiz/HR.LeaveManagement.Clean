using HR.LeaveManagement.Domain;
using HR.LeaveManagement.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Shouldly;

namespace HR.LeaveManagament.Persistance.IntegrationTests
{
    public class HrDatabaseContextTests
    {
        private HrDatabaseContext _hrDatabaseContext;

        public HrDatabaseContextTests()
        {
            var dbOptions = new DbContextOptionsBuilder<HrDatabaseContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            _hrDatabaseContext = new HrDatabaseContext(dbOptions);
        }

        [Fact]
        public async Task Save_SetDateCreatedAndModifiedValueAsync()
        {
            // Arrange
            var leaveType = new LeaveType 
            { 
                Id = 1, 
                DefaultDays = 10, 
                Name = "Test Vacation" 
            };

            // Act
            await _hrDatabaseContext.LeaveTypes.AddAsync(leaveType);
            await _hrDatabaseContext.SaveChangesAsync();

            // Assert
            leaveType.DateCreated.ShouldNotBeNull();
            leaveType.DateModified.ShouldNotBeNull();
        }
    }
}