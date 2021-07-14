using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignatureGenerator.Entities;
namespace SignatureGenerator.Pages.Firma
{
    public partial class Firma
    {
        private Client _Client { get; set; }
        public Client Client { get { return _Client; } set { _Client = value; } } 
        protected override async Task OnInitializedAsync()
        {
            Client = new Client();
        }
    }
}
