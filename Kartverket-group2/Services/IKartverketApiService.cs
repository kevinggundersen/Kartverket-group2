using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartverket_group2.Services
{
    public interface IKartverketApiService
    {
        Task<string> GetMunicipalityNumberAsync(double longitude, double latitude);
    }
}
