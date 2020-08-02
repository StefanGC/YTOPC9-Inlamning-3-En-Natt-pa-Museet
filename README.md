# [YTOPC9] Inlamning 3: En natt på Museet

### Uppgiftsbeskrivning
Ni jobbar som frilansande programmerare och har fått ett uppdrag att göra en virtualisering av ett konstmuseum som ska vara användbart från en gammal datorterminal som kommer stå i museets entré. Man ska därför i ett konsolprogram kunna vandra runt i museumets olika rum och få beskrivningar av konstverken i det rummet. Konstmuseumets personal är väldigt positivt inställda och nyfikna på er lösning, och räknar med att detta kommer vara en stor publikdragare!

### Tänk på...
Strukturen på ditt program är i denna uppgift mer än tidigare upp till dig, så tänk på att tillämpa vad du lärt dig om objektorienterad programmering.
Utmaningen i denna uppgift är strukturen mellan de olika rummen och hur användaren kan navigera mellan dessa i programmet. Du ska även implementera tre stycken valfria enhetstester och motivera dessa i din rapport.

Du borde nogrant fundera igenom strukturen på ditt program och skriva dessa tester först innan du börjar med ditt konsolprogram.

### Kravspecifikation:

*   Lösningen ska bestå av en körbar konsolapplikation skriven i C# (netcoreapp2.2 eller netcoreapp3.0)
*   När man startar programmet ska man som användare starta i museets entre, och kunna navigera runt i hela byggnaden enligt kartan.
*   När programmet startar ska man få en förklaring på hur man använder programmet.
*   Det ska inte gå "magiskt" förflytta sig i museet, vill man komma till det blåa rummet måste man alltså gå via korridoren och det gröna rummet.
*   När man befinner sig i ett rum ska man kunna se, antigen automatiskt eller via ett val, de konstverk som finns i rummet. Se listan nedanför med konstverk i rummen.
*   Strukturen på ditt program måste vara så att det vore enkelt att flytta konstverk mellan rummen i museet, eller att bygga om museet med olika rum.
*   Varje konstverk i museet har en titel, beskrivning och en uppehovsmakare.
*   Den inlämnade konsolapplikationen ska bestå av en "Program.cs" fil, en ".csproj" fil samt en fil för varje extra klass du skapar.
*   Konsolapplikationen ska lämnas in med ett tillhörande testprogram, där minst 3 enhetstester är implementerade.
*   Ingen information behöver sparas mellan körningar av programmet.

### Konstverk:

*I denna uppgift får du själv välja vilken typ av museeum som du har virutaliserat, välj gärna något som du själv har intresse av!* 

Detta antal av konstverk ska finnas i varje rum:

 - **Vita rummet**: ett (1) konstverk
 - **Svarta rummet**: inga (0) konstverk
 - **Lila rummet**: fyra (4) konstverk
 - **Blåa rummet**: ett (1) konstverk
 - **Röda rummet**: tre (3) konstverk
 - **Gröna rummet**: två (2) konstverk
 - **Korridoren**: inga (0) konstverk
 - **Entreen**: inga (0) konstverk

### Ytterkliga önskemål

För VG på uppgiften krävs det att det finns totalt fem (5) stycken enhetesteser, och att Console är väl separerat från programmets övriga logik (vilket rum är användaren i, vilka konstverk finns där osv).

För VG krävs också att när programmet startar kan man välja mellan 2 olika museeum att besöka. Det andra museet ska använda samma klasser och programstruktur som det första men kan ha en annan rumskonfiguration och konstverk i byggnaden.

### Rapport och inlämning

Inlämningen ska innehålla en rapport som kort beskriver hur du strukturerat din kod genom användandet av de objektorienterade principerna, samt som beskriver vilka enhetstester du skapat och varför du valt att göra just dessa tester.

När du är färdig med din uppgift så skall du bifoga repporten som ett pdf-dokument, som dessutom innehåller en länk till ditt gitrepo.
