namespace api_filmes_senai.Utils
{
    public static class Criptografia
    {
        public static string GerarHash(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }

        public static bool CompararHash(string senhaInformada, string senhaBD)
        {
            return BCrypt.Net.BCrypt.Verify(senhaInformada, senhaBD);
        }
    }
}
