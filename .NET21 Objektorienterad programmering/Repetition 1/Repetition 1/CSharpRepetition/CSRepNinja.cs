#pragma warning disable RCS1163 // Unused parameter.
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable RCS1118 // Mark local variable as const.
namespace CSharpRepetition.Net20.MarcusMedina
{
    using CSharpRepetition.MarcusKod;

    /// <summary>
    /// Testa dina kodninjakunskaper.
    /// </summary>
    public class CSRepNinja
    {
        /// <summary>
        /// Den här metoden krypterar en textsträng enligt Caesarchiffer,
        /// enbart åäö, bokstäver, siffror, punkt, komma och mellanslag är godkända
        /// för input, övrigt ska ignoreras
        /// Nyckeln talar om hur många positioner en bokstav eller ett nummer ska flyttas
        /// nyckel:3 --> a=c, b=d, c=e.
        /// </summary>
        /// <param name="code">Text som ska krypteras.</param>
        /// <param name="key">Nyckel som ska användas till kryptering.</param>
        /// <returns>Krypterad sträng.</returns>
        public string Caesarchiffer(string code, int key)
        {
            string resultat = "";
            // ---------------------------------------------------------------------------------
            // Skriv din kod nedan
            // ---------------------------------------------------------------------------------
            string allowedCharacters = "åäöabcdefghijklmnopqrstuvwxyz ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890.,";
            bool allowed = false;
            for (int i = 0; i < code.Length; i++)
            {
                allowed = false;

                for (int c = 0; c < allowedCharacters.Length; c++)
                {
                    if(code[i].Equals(allowedCharacters[c]))
                    {
                        allowed = true;
                        break;
                    }
                }

                if (allowed)
                {
                    resultat += (char)((int)code[i] + key - 1);
                }
                else
                {
                    resultat += code[i];
                }

            }
            // ---------------------------------------------------------------------------------
            NiceDebug.DebugThis("Caesar :" + resultat);
            return resultat;
        }

        /// <summary>
        /// Dechifrerar text.
        /// </summary>
        /// <param name="code">Texten.</param>
        /// <param name="key">Nyckel.</param>
        /// <returns>Dechifrerad text.</returns>
        public string Caesardechiffer(string code, int key)
        {
            string resultat = "";
            // ---------------------------------------------------------------------------------
            // Skriv din kod nedan
            // ---------------------------------------------------------------------------------
            string allowedCharacters = "åäöabcdefghijklmnopqrstuvwxyz ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890.,";
            bool allowed = false;
            for (int i = 0; i < code.Length; i++)
            {
                allowed = false;

                for (int c = 0; c < allowedCharacters.Length; c++)
                {
                    if (((char)((int)code[i]-key+1)).Equals(allowedCharacters[c]))
                    {
                        allowed = true;
                        break;
                    }
                }

                if (allowed)
                {
                    resultat += (char)((int)code[i] - key + 1);
                }
                else
                {
                    resultat += code[i];
                }

            }
            // ---------------------------------------------------------------------------------
            return resultat;
        }
    }
}
#pragma warning restore RCS1118 // Mark local variable as const.
#pragma warning restore IDE0060 // Remove unused parameter
#pragma warning restore RCS1163 // Unused parameter.
