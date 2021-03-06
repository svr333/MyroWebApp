﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyroWebApp.Xamarin.Services
{
    public interface IDataStorage<T>
    {
        T Current { get;}

        Task<bool> AddItemAsync(T item);
        Task<bool> UpdateItemAsync(T item);
        Task<bool> DeleteItemAsync(string id);
        Task<T> GetItemAsync(string id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
