using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using SignatureGenerator.Entities;
namespace SignatureGenerator.Pages.Firma
{
    public partial class Firma
    {
        [Inject]
        public  IJSRuntime jSRuntime { get; set; }
        private Client _Client { get; set; } = new Client();
        //public Client Client { get { return _Client; } set { _Client = value; } } 
        private Client Client { get { return _Client; } set { _Client = value; SetClientToCard();  } }
        public Entities.Signature _Signatures { get; set; }
        public Entities.Signature Signatures { get { return _Signatures; } set { _Signatures = value; SetColorToCard(); } }
        protected override async Task OnInitializedAsync()
        {
            Signatures = new Entities.Signature();
            Client = new Client();
        }

        private void GetClientValues(Client client)
        {
            Client = client;
        }
        private Client SetClientToCard()
        {
         
            return Client;
        }
        private Entities.Signature SetColorToCard()
        {
            return Signatures;
        }
        private async void SaveSignature()
        {
            await JSInteropUtils.SaveDivAsImage(jSRuntime,"Signature");
        }

        private string IsColorCheck(string color)
        {
            string ischeck = "";
            if (Signatures.Color == color)
            {
                ischeck = "IsColorChecked";
            }
            return ischeck;
        }
    }
}
