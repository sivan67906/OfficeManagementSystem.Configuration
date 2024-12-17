using Configuration.Application.Services;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;

namespace Configuration.Infrastructure.Services;

public class ConsumerService(IGenericRepository<Consumer> consumerRepository)
    : IConsumerService
{
    public async Task<Consumer> GetByConsumerNameAsync(string consumerName)
    {
        var consumer = await consumerRepository.GetAllAsync();
        return consumer.FirstOrDefault(
            p => (p.FirstName + p.LastName).Equals(consumerName, StringComparison.OrdinalIgnoreCase) && p.IsActive == true);
    }

    public async Task<IEnumerable<Consumer>> SearchConsumersByNameAsync(string consumerName)
    {
        var consumers = await consumerRepository.GetAllAsync();
        return consumers.Where(
            p => (p.FirstName + p.LastName).Contains(consumerName, StringComparison.OrdinalIgnoreCase) && p.IsActive == true);
    }

    public async Task<IEnumerable<Consumer>> SearchConsumersByPhoneAsync(string phoneNumber)
    {
        var consumers = await consumerRepository.GetAllAsync();
        return consumers.Where(
            p => (p.PhoneNumber).Contains(phoneNumber, StringComparison.OrdinalIgnoreCase) && p.IsActive == true);
    }

    public async Task<IEnumerable<Consumer>> SearchConsumersByDateAsync(DateTime searchDate)
    {
        var consumers = await consumerRepository.GetAllAsync();
        return consumers
            .Where(x => x.IsActive == true)
                            .ToList()
                            .Where(x => DateTime.Compare(x.CreatedDate.Date, searchDate.Date) == 0)
                            .ToList();
    }

    public async Task<IEnumerable<Consumer>> SearchConsumersByDateBetweenAsync(
        DateTime startDate, DateTime endDate)
    {
        var consumers = await consumerRepository.GetAllAsync();
        return consumers.Where(x => x.CreatedDate >= startDate
                           && x.CreatedDate <= endDate && x.IsActive == true);
    }

    //public async Task UpdateConsumerAsync(Consumer updateConsumer)
    //{
    //    var existingConsumer = await _consumerRepository.GetByIdAsync(updateConsumer.Id);

    //    if (existingConsumer == null)
    //    {
    //        throw new KeyNotFoundException($"Consumer with ID {updateConsumer.Id} not found.");
    //    }

    //    // Detach the existing consumer to avoid tracking conflict
    //    _consumerRepository.Detach(existingConsumer);

    //    // Apply changes to the consumer
    //    existingConsumer.Name = updateConsumer.Name;
    //    existingConsumer.Description = updateConsumer.Description;
    //    existingConsumer.Price = updateConsumer.Price;
    //    existingConsumer.StockQuantity = updateConsumer.StockQuantity;
    //    existingConsumer.Category = updateConsumer.Category;
    //    existingConsumer.SKU = updateConsumer.SKU;
    //    existingConsumer.ImageUrl = updateConsumer.ImageUrl;
    //    existingConsumer.UpdatedDate = updateConsumer.UpdatedDate;
    //    existingConsumer.IsActive = updateConsumer.IsActive;

    //    // Call the repository's UpdateAsync method
    //    await _consumerRepository.UpdateAsync(existingConsumer);
    //}
}
