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
    
    public class IModuleInstanceContractToViewAddInAdapter : JumpstartMenu.Views.IModuleInstance
    {
        private Start9.Api.Contracts.IModuleInstanceContract _contract;
        private System.AddIn.Pipeline.ContractHandle _handle;
        static IModuleInstanceContractToViewAddInAdapter()
        {
        }
        public IModuleInstanceContractToViewAddInAdapter(Start9.Api.Contracts.IModuleInstanceContract contract)
        {
            _contract = contract;
            _handle = new System.AddIn.Pipeline.ContractHandle(contract);
        }
        public JumpstartMenu.Views.IModule Instance
        {
            get
            {
                return JumpstartMenu.Adapters.IModuleAddInAdapter.ContractToViewAdapter(_contract.Instance);
            }
        }
        public int ProcessId
        {
            get
            {
                return _contract.ProcessId;
            }
        }
        internal Start9.Api.Contracts.IModuleInstanceContract GetSourceContract()
        {
            return _contract;
        }
    }
}

