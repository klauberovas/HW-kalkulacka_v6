# Kalkulaèka - Domácí úkol

## Popis projektu
Tento projekt pøedstavuje implementaci jednoduché kalkulaèky v jazyce C# podle zadanıch poadavkù. Projekt je rozdìlen do dvou èástí:
- **`Calculator.cs`**: Obsahuje tøídu `Calculator`, která implementuje pouze matematické operace a uchovává poslední vısledek.
- **`Program.cs`**: Obsahuje veškerou logiku uivatelské interakce, vèetnì naèítání vstupù, vıpisù do konzole, kontrol správného zadání, opakovací logiky a monosti ukonèení programu.

## Funkce projektu
1. **Tøída `Calculator` (`Calculator.cs`)**:
   - Obsahuje metody pro základní matematické operace (sèítání, odèítání, násobení, dìlení).
   - Uchovává poslední vısledek provedené operace.

2. **Uivatelská interakce (`Program.cs`)**:
   - Funkce pro naèítání vstupù od uivatele, vèetnì kontroly správnosti zadanıch hodnot.
   - Funkce pro parsování vstupù na poadované datové typy.
   - Vıpis vısledkù do konzole.
   - Logika pro opakování vıpoètù a ukonèení programu na ádost uivatele.

3. **Statické metody (`Program.cs`)**:
   - Obsahují implementaci naèítání desetinnıch èísel a operátorù, aby byla logika pøehlednì oddìlená od metody `Main`.

## Pouití
1. Spuste projekt v prostøedí Visual Studio nebo jiném kompatibilním vıvojovém prostøedí.
2. Program vás vyzve k zadání dvou èísel a matematického operátoru. (Po vıpoètu první operace se zadává u jen matematickı operátor a druhé èíslo.)
3. Po zpracování vstupù kalkulaèka zobrazí vısledek vıpoètu.
4. Uivatel mùe pokraèovat v dalších vıpoètech nebo program ukonèit pomocí X.

## Zadané poadavky
- Oddìlení logiky tøídy `Kalkulacka` od hlavního programu. Tøída má implementovat pouze matematické operace a uchovávat poslední vısledek.
- Naèítání desetinnıch èísel a operátorù bylo pøesunuto do samostatnıch statickıch metod v souboru `Program.cs`.
- Hlavní metoda `Main` je urèena pouze pro spuštìní a øízení celého procesu.

## Struktura projektu
- **`Calculator.cs`**: Obsahuje tøídu `Calculator`.
- **`Program.cs`**: Obsahuje hlavní logiku programu a uivatelskou interakci.

