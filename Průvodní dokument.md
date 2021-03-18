# Průvodní dokument
Tento dokument slouží k ulehčení orientace a vysvětlení některých
 složek v tomto archivu.

---
## Textová část
Složka **'Textová část'** je rozdělená do několika podsložek:
 * 📁**Obrázky**
    * 📁**Praktická část** - Veškeré snímky obrazovky využité v praktické části DMP
    * 📁**Teoretická část** - Veškeré snímky obrazovky využité v teoretické části DMP
 * 📁**PDF dokument** - Obsahuje textovou část DMP ve formátu .PDF *(Záloha souboru přiloženého do prostředí Moodle mimo tento archiv)* 
 * 📁**Word dokument** - Obsahuje textovou část DMP ve formátu .docx

---
## Praktická část
Složka **'Praktická část'** je rozdělena do mnoha podsložek:
 * 📁**Aplikace** - Obsahuje spustitelné soubory
    * 📁**Bankomat** - Kořenová složka aplikace
        * 📁**Karty** - Obsahuje dvě karty pro simulaci funkcí bankomatu
        * 📁**Log** - Obsahuje všechny logovací soubory, které se vytváří automaticky při zavření bankomatu
        * 📁**Money** - Slouží jako peněženka - obsahuje peníze které si uživatel vybere na stránce "Výběr hotovosti"
        * 📁**Peníze** - Obsahuje peníze které je možné vložit na účet
        * 💻**PSBNebesky.exe** - Aplikace bankomatu
    * 📁**Server**
        * 💻**PSBNebeskyServer.exe** - Aplikace serveru bankomatu
 * 📁**Instalační sada** - Obsahuje instalační nástroj bankomatu, pro případ že se nedaří spustit bankomat ve  složce **Bankomat**
    * 📁**Bankomat**
        * 💻**setup.exe** - Instalační nástroj
 * 📁**Zdrojový kód** - Obsahuje zdrojové kódy pro bankomat, server a databázi
    * 📁**Bankomat**
        * 📁**PSBNebesky**
            * 🧰**PSBNebesky.sln** - Otevře zdrojový kód bankomatu
    * 📁**Databáze**
        * 🧰**PSBDatabáze.sql** - Zdrojový kód databáze v MySQL/MariaSQL
    * 📁**Server**
        * 📁**PSBNebeskyServer**
            * 🧰**PSBNebeskyServer.sln** - Otevře zdrojový kód serveru

---
## Dodatečné informace
Následující část dokumentu se bude věnovat vysvětlení některých podrobností.
 
  Pro zprovoznění databáze doporučuji využít software XAMPP, při instalaci je třeba zvolit si moduly **Apache** a **MySQL**. Následně stačí stisknout u zvolených modůlů tlačítka **Start** a připojit se do prostředí **MySQL** pomocí tlačítka **Admin**. V prostředí MyPHP admin je pak potřeba spustit přiložený SQL skript. Po vytvoření databáze by se při spuštení serveru mělo v konzoli objevit *"Connected to database"*. Pokud se toto v konzoli zobrazí, je možné spustit bankomat bez chybové hlášky. V databázi jsou předpřipravené účty, lze je otevřít pomocí přiložených karet ve formátu .json.

## Zdroje a poděkování

V samotném simulátoru je použito několik obrázků a font z volně dostupných zdrojů. 

Ikony na tlačítku pro změnu jazyka pochází z volně dostupné kolekce ikon od společnosti Microsoft. Dostupné z https://www.microsoft.com/en-us/download/details.aspx?id=35825 . Datum získání 18.3.2021.

Byl využit volně dostupný font DejaVu. Seznam autorů: https://dejavu-fonts.github.io/Authors.html . Font dostupný z: https://dejavu-fonts.github.io . Pod licenčními podmínkami uvedenými zde: https://dejavu-fonts.github.io/License.html. Datum získání 18.3.2021.


Tímto bych chtěl poděkovat:
 * Paní Ing. arch. Marii Selingerové za všeobecnou pomoc při tvorbě a formátování textové části dlouhodobé maturitní práce.
 * Panu RNDr. Ivu Markovi za vedení mé dlouhodobé maturitní práce, za odbornou pomoc s tvorbou kódu a za revizi odbornosti textové části dlouhodobé maturitní práce.
 * Paní Ing. Dagmar Hadové za revizi anglického překladu prostředí bankomatu.
 * Paní PhDr. Bečkové Michaele Ph.D. za redakci textové části dlouhodobé maturitní práce.
 * Markétě Bečkové za revizi anglického překladu prostředí bankomatu.
 * Andreji Karovinovi za technickou podporu.