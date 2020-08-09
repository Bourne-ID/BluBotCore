using System;
using System.Text;

namespace BluBotCore.Other
{
    public class Crypt
    {
        const string ENV_VAR = "BOT_PASSWORD";
        public static byte[] Key
        {
            get
            {
                string password = Environment.GetEnvironmentVariable(ENV_VAR);
                if (String.IsNullOrEmpty(password))
                {
                    throw new Exception($"Set environment variable {ENV_VAR} to set the application password");
                }
                return Encoding.ASCII.GetBytes(password.PadLeft(32, 'a').Substring(0,32));
            }
        }
    }
}