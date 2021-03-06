//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JumpstartMenu.Adapters
{
    
    public class IReceiverEntryContractToViewAddInAdapter : JumpstartMenu.Views.IReceiverEntry
    {
        private Start9.Api.Contracts.IReceiverEntryContract _contract;
        private System.AddIn.Pipeline.ContractHandle _handle;
        private JumpstartMenu.Adapters.IMessageEventHandlerViewToContractAddInAdapter MessageReceived_Handler;
        private static System.Reflection.MethodInfo s_MessageReceivedEventAddFire;
		public event System.EventHandler<JumpstartMenu.Views.MessageReceivedEventArgs>MessageReceived{
			add{
				if (_MessageReceived == null)
				{
					_contract.MessageReceivedEventAdd(MessageReceived_Handler);
				}
				_MessageReceived += value;
				}
			remove{
					_MessageReceived -= value;
				if (_MessageReceived == null)
				{
					_contract.MessageReceivedEventRemove(MessageReceived_Handler);
				}
				}
		}
        static IReceiverEntryContractToViewAddInAdapter()
        {
            s_MessageReceivedEventAddFire = typeof(IReceiverEntryContractToViewAddInAdapter).GetMethod("Fire_MessageReceived", ((System.Reflection.BindingFlags)(36)));
        }
        public IReceiverEntryContractToViewAddInAdapter(Start9.Api.Contracts.IReceiverEntryContract contract)
        {
            _contract = contract;
            _handle = new System.AddIn.Pipeline.ContractHandle(contract);
            MessageReceived_Handler = new JumpstartMenu.Adapters.IMessageEventHandlerViewToContractAddInAdapter(this, s_MessageReceivedEventAddFire);
        }
        public System.Type Type
        {
            get
            {
                return _contract.Type;
            }
        }
        public string FriendlyName
        {
            get
            {
                return _contract.FriendlyName;
            }
        }
        private event System.EventHandler<JumpstartMenu.Views.MessageReceivedEventArgs> _MessageReceived;
        public void SendMessage(JumpstartMenu.Views.IMessage message)
        {
            _contract.SendMessage(JumpstartMenu.Adapters.IMessageAddInAdapter.ViewToContractAdapter(message));
        }
        internal virtual void Fire_MessageReceived(JumpstartMenu.Views.MessageReceivedEventArgs args)
        {
            if ((_MessageReceived == null))
            {
            }
            else
            {
                _MessageReceived.Invoke(this, args);
            }
        }
        internal Start9.Api.Contracts.IReceiverEntryContract GetSourceContract()
        {
            return _contract;
        }
    }
}

