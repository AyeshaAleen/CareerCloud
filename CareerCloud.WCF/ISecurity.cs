using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.WCF
{
    [ServiceContract]
    public interface ISecurity
    {
        [OperationContract]
        void AddSecurityLogin(SecurityLoginPoco[] items);
        [OperationContract]
        void UpdateSecurityLogin(SecurityLoginPoco[] items);
        [OperationContract]
        List<SecurityLoginPoco> GetAllSecurityLogin();
        [OperationContract]
        SecurityLoginPoco GetSingleSecurityLogin(string Id);
        [OperationContract]
        void RemoveSecurityLogin(SecurityLoginPoco[] items);



        [OperationContract]
        void AddSecurityLoginsLog(SecurityLoginsLogPoco[] items);
        [OperationContract]
        void UpdateSecurityLoginsLog(SecurityLoginsLogPoco[] items);
        [OperationContract]
        List<SecurityLoginsLogPoco> GetAllSecurityLoginsLog();
        [OperationContract]
        SecurityLoginsLogPoco GetSingleSecurityLoginsLog(string Id);
        [OperationContract]
        void RemoveSecurityLoginsLog(SecurityLoginsLogPoco[] items);



        [OperationContract]
        void AddSecurityLoginsRole(SecurityLoginsRolePoco[] items);
        [OperationContract]
        void UpdateSecurityLoginsRole(SecurityLoginsRolePoco[] items);
        [OperationContract]
        List<SecurityLoginsRolePoco> GetAllSecurityLoginsRole();
        [OperationContract]
        SecurityLoginsRolePoco GetSingleSecurityLoginsRole(string Id);
        [OperationContract]
        void RemoveSecurityLoginsRole(SecurityLoginsRolePoco[] items);



        [OperationContract]
        void AddSecurityRole(SecurityRolePoco[] items);
        [OperationContract]
        void UpdateSecurityRole(SecurityRolePoco[] items);
        [OperationContract]
        List<SecurityRolePoco> GetAllSecurityRole();
        [OperationContract]
        SecurityRolePoco GetSingleSecurityRole(string Id);
        [OperationContract]
        void RemoveSecurityRole(SecurityRolePoco[] items);
    }
}
