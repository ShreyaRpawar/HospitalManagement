
using Hospital_Patient_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Patient_system
{
    internal partial interface IDataAccess<TEntity, in TPk> where TEntity : class
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task<IEnumerable<PatientInfo>> GetAsync();
        Task<IEnumerable<PatientReport>> GetAsync1();

    }

   
}

