namespace OngDonationApi
{
    public class ExtensionsMethods
    {
        public static string removeSpecialCharacter(string text)
        {
            string withSpecialCharacter = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string noSpecialCharacter = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

            for (int i = 0; i < withSpecialCharacter.Length; i++)
            {
                text = text.Replace(withSpecialCharacter[i].ToString(), noSpecialCharacter[i].ToString());
            }
            return text;
        }
    } 
}
