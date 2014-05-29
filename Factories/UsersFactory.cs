using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZohoCrmConnector.Entities;

namespace ZohoCrmConnector.Factories
{
    class UsersFactory : RestSharpFactory
    {
        public UsersFactory(string userToken)
            : base(userToken)
        {

        }

        /// <summary>
        /// To get the list of users in your organization
        /// </summary>
        /// <param name="type">This parameter takes one of the following values:
        ///                         AllUsers - To list all users in your organization (both active and inactive users)
        ///                         ActiveUsers - To get the list of all Active Users
        ///                         DeactiveUsers - To get the list of all users who were deactivated
        ///                         AdminUsers - To get the list of all users with the Administrative privileges
        ///                         ActiveConfirmedAdmins - To get the list of users with the administrative privileges and are also confirmed</param>
        /// <returns>List of Users</returns>
        public List<Users> getUsers(string type)
        {
            return this.getUsers<List<Users>>(type);
        }

        /// <summary>
        /// To get the list of users in your organization
        /// </summary>
        /// <param name="type">This parameter takes one of the following values:
        ///                         AllUsers - To list all users in your organization (both active and inactive users)
        ///                         ActiveUsers - To get the list of all Active Users
        ///                         DeactiveUsers - To get the list of all users who were deactivated
        ///                         AdminUsers - To get the list of all users with the Administrative privileges
        ///                         ActiveConfirmedAdmins - To get the list of users with the administrative privileges and are also confirmed</param>
        ///  Dictionary:                 key: newFormat	        value: (1 or 2)	newFormat=1: To exclude fields with "null" values while fetching data from your CRM account.
        /// <returns>List of Users</returns>
        public List<Users> getUsers(string type, Dictionary<string, string> parameters)
        {
            return this.getMyRecords<List<Users>>("Users", parameters);
        }
    }
}
