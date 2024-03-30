namespace Constants.Route.UI
{
    public static class UserServiceRoute
    {

        public const string CheckUserStatus = URL.APIGateway + "UserLogin/checkUserStatus";
        public const string RegisterUser = URL.APIGateway + "UserRegistration/RegisterUser";
        public const string InsertUrl = URL.APIGateway + "Url/InsertUrl";
        public const string UpdateUserWithUrls = URL.APIGateway + "/UserRegistration/UpdateUserWithUrlss";
        public const string GetUserWithUrls = URL.APIGateway + "UserRegistration/GetUserWithUrls";
        public const string GetUsersAddtionalAddress = URL.APIGateway + "UserRegistration/GetUsersAddtionalAddress";
        public const string UpdateUserAdditionalAddress = URL.APIGateway + "UserRegistration/UpdateUserAdditionalAddress";
        public const string GetDataForSchoolRegistration=URL.APIGateway+"GetDataForAddInstitute/GetData";
        public const string RegisterInstitute = URL.APIGateway + "RegisterInstitute/InsertInstituteDeatails";
        public const string UpdateInstituteui = URL.APIGateway + "RegisterInstitute/UpdateInstitute";
        public const string GetUserInstitute = URL.APIGateway +"GetDataForAddInstitute/GetUserInstitute";

 
    }
}