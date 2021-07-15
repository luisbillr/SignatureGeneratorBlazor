using Microsoft.AspNetCore.Components;
using SignatureGenerator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignatureGenerator.Shared.Components.Clients
{
    public partial class CCreateOrEditClient
    {
        [Parameter]
        public EventCallback<Client> EClient { get; set; }
        public Client _Client { get; set; }
        public Client Client { get { return _Client; } set { _Client = value; SetClientValue(); } }
        protected override async Task OnInitializedAsync()
        {
            Client = new Client();
            
        }
        private void SetClientValue()
        {
            EClient.InvokeAsync(Client);
        }
    }
}
