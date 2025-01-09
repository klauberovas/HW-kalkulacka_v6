# Kalkula�ka - Dom�c� �kol

## Popis projektu
Tento projekt p�edstavuje implementaci jednoduch� kalkula�ky v jazyce C# podle zadan�ch po�adavk�. Projekt je rozd�len do dvou ��st�:
- **`Calculator.cs`**: Obsahuje t��du `Calculator`, kter� implementuje pouze matematick� operace a uchov�v� posledn� v�sledek.
- **`Program.cs`**: Obsahuje ve�kerou logiku u�ivatelsk� interakce, v�etn� na��t�n� vstup�, v�pis� do konzole, kontrol spr�vn�ho zad�n�, opakovac� logiky a mo�nosti ukon�en� programu.

## Funkce projektu
1. **T��da `Calculator` (`Calculator.cs`)**:
   - Obsahuje metody pro z�kladn� matematick� operace (s��t�n�, od��t�n�, n�soben�, d�len�).
   - Uchov�v� posledn� v�sledek proveden� operace.

2. **U�ivatelsk� interakce (`Program.cs`)**:
   - Funkce pro na��t�n� vstup� od u�ivatele, v�etn� kontroly spr�vnosti zadan�ch hodnot.
   - Funkce pro parsov�n� vstup� na po�adovan� datov� typy.
   - V�pis v�sledk� do konzole.
   - Logika pro opakov�n� v�po�t� a ukon�en� programu na ��dost u�ivatele.

3. **Statick� metody (`Program.cs`)**:
   - Obsahuj� implementaci na��t�n� desetinn�ch ��sel a oper�tor�, aby byla logika p�ehledn� odd�len� od metody `Main`.

## Pou�it�
1. Spus�te projekt v prost�ed� Visual Studio nebo jin�m kompatibiln�m v�vojov�m prost�ed�.
2. Program v�s vyzve k zad�n� dvou ��sel a matematick�ho oper�toru. (Po v�po�tu prvn� operace se zad�v� u� jen matematick� oper�tor a druh� ��slo.)
3. Po zpracov�n� vstup� kalkula�ka zobraz� v�sledek v�po�tu.
4. U�ivatel m��e pokra�ovat v dal��ch v�po�tech nebo program ukon�it pomoc� X.

## Zadan� po�adavky
- Odd�len� logiky t��dy `Kalkulacka` od hlavn�ho programu. T��da m� implementovat pouze matematick� operace a uchov�vat posledn� v�sledek.
- Na��t�n� desetinn�ch ��sel a oper�tor� bylo p�esunuto do samostatn�ch statick�ch metod v souboru `Program.cs`.
- Hlavn� metoda `Main` je ur�ena pouze pro spu�t�n� a ��zen� cel�ho procesu.

## Struktura projektu
- **`Calculator.cs`**: Obsahuje t��du `Calculator`.
- **`Program.cs`**: Obsahuje hlavn� logiku programu a u�ivatelskou interakci.

