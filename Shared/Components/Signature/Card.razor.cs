using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using SignatureGenerator.Entities;
namespace SignatureGenerator.Shared.Components.Signature
{
    public partial class Card
    {
      
        private Client _Client { get; set; }
        [Parameter]
        public Client Client { get { return _Client; } set { _Client = value; } }

        protected override async Task OnInitializedAsync()
        {
            
            Client = new Client();
           
        }
    }
}
