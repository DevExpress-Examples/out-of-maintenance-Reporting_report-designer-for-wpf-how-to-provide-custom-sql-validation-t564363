using DevExpress.DataAccess.Wizard.Services;
using DevExpress.DataAccess.ConnectionParameters;

namespace ValidateCustomSql {
    public class MyCustomQueryValidator : ICustomQueryValidator {
        public bool Validate(DataConnectionParametersBase connectionParameters, string sql, ref string message) {
            // Add your custom validation logic here. 
            // The method should return true if the query is valid and false otherwise. 
            return false;
        }
    }
}
