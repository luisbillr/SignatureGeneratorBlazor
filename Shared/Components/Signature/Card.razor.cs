using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SignatureGenerator.Entities;
namespace SignatureGenerator.Shared.Components.Signature
{
    public partial class Card
    {
   
        [Parameter]
        public Client Client { get; set; }
        public Entities.Signature Signatures { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Signatures = new Entities.Signature();
            Client = new Client();  
        }
        //private Task HandleColorPiker(MouseEventArgs args)
        //{
        //    Signatures.Color = args.va
        //    //EClient.InvokeAsync(Client);
        //}
    }
}
