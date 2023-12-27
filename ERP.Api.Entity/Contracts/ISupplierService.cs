﻿using ERP.Api;

namespace ERP.Api.Entity.Contracts;

public interface ISupplierService
{
    public Task<int> CreateSupplier(Supplier supplier);
    public Task<bool> UpdateSupplier(Supplier supplier);
    public Task<bool> DeleteSupplier(int id);
    public Task<IEnumerable<Supplier>> GetAll();
    public Task<Supplier> GetById(int id);
    public Task<IEnumerable<Supplier>> GetByName(string name);
    public Task<IEnumerable<Supplier>> GetActiveSupplier();
}
