using System;
using System.Collections.Generic;
using System.Text;
using Xama1.Model;
using Xama1.Connection;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Xama1.Data
{
    public class DPokemon
    {
        public async Task InsertPokemon(MPokemon parameters)
        {
            await Cconnection.firebase
                .Child("Pokemon")
                .PostAsync(new MPokemon()
                {
                    Background = parameters.Background,
                    PowerColor = parameters.PowerColor,
                    Icon = parameters.Icon,
                    Name = parameters.Name,
                    No = parameters.No,
                    Power = parameters.Power
                });
        }
        public async Task<List<MPokemon>> ShowPokemon()
        {
            return (await Cconnection.firebase
                .Child("Pokemon")
                .OnceAsync<MPokemon>())
                .Select(item => new MPokemon
                {
                    IDPokemon=item.Key,
                    Name=item.Object.Name,
                    Background = item.Object.Background,
                    PowerColor = item.Object.PowerColor, 
                    No = item.Object.No,
                    Power=item.Object.Power,
                    Icon = item.Object.Icon

                }).ToList();
        }

    }
}
