using System;
using System.Collections.Generic;

namespace OM.Business.Models;

public partial class CustomerModel
{
    public CustomerModel(OM.Data.Entities.Customer entity)
    {
        CustomerId = entity.CustomerId;
        FirstName = entity.FirstName;
        LastName = entity.LastName;
        Email = entity.Email;
        CreatedAt = entity.CreatedAt;
    }
    public int CustomerId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string FullName { get { return FirstName + LastName; } }

    public string Email { get; set; } = null!;
    public DateTime? CreatedAt { get; set; }
}
