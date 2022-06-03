public static bool VerifyPassword(string u, string pwd2)
{
    if (String.IsNullOrWhiteSpace(u) || String.IsNullOrWhiteSpace(pwd2))
        return false;

    string dbUser; // inconsistency declaring / initialising variables
    string dbPass = null;

    using (var conn = new SqlConnection("DefaultConnection"))
    using (var command = new SqlCommand("SELECT * FROM Users WHERE uName = '" + u + "'", conn)) // this returns all columns from Users table, we only need to return the password column where uName is equal to 'u'
    {
        conn.Open(); // this should be surrounded by a try, catch block
        command.CommandType = CommandType.Text;
        SqlDataReader rdr = command.ExecuteReader(); // executeScalar may be better here, something like
                                                     // string dbPass = command.Parameters.AddwithValue("@password", pwd2);
                                                     // var result = command.ExecuteScaler();
                                                     // then check the value of result agains dbPass

        while (rdr.Read()) // this while loop would not be needed if using executeScalar
        {
            dbUser = rdr["uName"].ToString();
            dbPass = rdr["uPass"].ToString();
        }
    }
    for (int j = 0; j < dbPass.Length; j++) // using a for loop to check over each character is inefficient here - see above use of 'executeScaler'
    {
        if (dbPass[j] == pwd2[j])
            continue;
        return false;
    }
    return true;
}