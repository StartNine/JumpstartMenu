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
    
    public class IMessageAddInAdapter
    {
        internal static JumpstartMenu.Views.IMessage ContractToViewAdapter(Start9.Api.Contracts.IMessageContract contract)
        {
            if ((contract == null))
            {
                return null;
            }
            if (((System.Runtime.Remoting.RemotingServices.IsObjectOutOfAppDomain(contract) != true) 
                        && contract.GetType().Equals(typeof(IMessageViewToContractAddInAdapter))))
            {
                return ((IMessageViewToContractAddInAdapter)(contract)).GetSourceView();
            }
            else
            {
                return new IMessageContractToViewAddInAdapter(contract);
            }
        }
        internal static Start9.Api.Contracts.IMessageContract ViewToContractAdapter(JumpstartMenu.Views.IMessage view)
        {
            if ((view == null))
            {
                return null;
            }
            if (view.GetType().Equals(typeof(IMessageContractToViewAddInAdapter)))
            {
                return ((IMessageContractToViewAddInAdapter)(view)).GetSourceContract();
            }
            else
            {
                return new IMessageViewToContractAddInAdapter(view);
            }
        }
    }
}

