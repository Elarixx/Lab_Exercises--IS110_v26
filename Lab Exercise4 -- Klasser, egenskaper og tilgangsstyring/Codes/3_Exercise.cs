using System;

namespace Lab_Exercise4.Codes
{
    /*
    ----- Øvelse 3: Du jobber i et system som består av flere prosjekter. Lag en klasse ConfigurationManager som: -----

          - Ikke skal være tilgjengelig fra andre prosjekter
          - Har egenskaper for:
             - Applikasjonsnavn
             - Versjonsnummer
        
        Krav:
          - Bruk internal der det er hensiktsmessig
          - Bruk auto-implementerte egenskaper
          - Klassen skal kunne brukes fritt innenfor samme prosjekt    
     */

    internal class Exercise3
    {
        // "Internal" gjør at egenskapene i klassen ikke er tilgjengelige utenfor dette prosjektet.
        internal class ConfigurationManager
        {
            /* Alle er offentlig auto-implementerte egenskaper
                * "get/set" lager og bruker et automatisk felt */
            internal string ApplicationName { get; set; }
            internal string VersionNumber { get; set; }
        }
    }
}
