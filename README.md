###########################################################################


# Projekt FROG
## Projekt oparty na arcade'owej grze -> 'Frogger'.


###########################################################################
* Data rozpoczęcia: 18.11.17
* Data zakończenia(mechanika): 25.11.17 
* Instrukcja zamieszczona w grze.
* Wykonanie w: WinForms, Visual Studio 2017 




> 18.12.17 - pozostałe rzeczy do rozmyślania na dłuugie wieczory ;-;

- Pojazd policyjny zachacza o żabę - problem pictureboxa żaby
- Gdy żaby wchodzą na kłody, kłoda jest przezroczysta
- Gdy przytrzyma się przycisk(dowolny) energia żaby szybciej się odnawia
- Gdy aktywuje sie menu escape i kliknie co innego niz spacje, to timery wznawiaja dzialanie...
- ~~Doprecyzować/Stworzyć lepszy algorytm wykrywania czy żaba jest na kłodzie~~
- Gdy załącza się muzyka z przegranej to dopóki nie odpalimy innego dźwięku w menu to ta dalej gra

**kwestie nierozwiązane:**
- ~~Jak wrzucić metodę, która ma KeyEvent do klasy?~~ 
- Gdzie stworzyć obiekt klasy z metodą KeyEvent? (Nie do public form bo wtedy nie działa..)
- Jak odseparować dwa KeyDown'y aby działały niezależnie od siebie? (ale żeby ten drugi sprawdzał co do tego pierwszego trafia)

**możliwości rozwinięcia projektu:**
- Tryb online(jeden z graczy jednocześnie jest klientem i hostuje serwer)
- Wprowadzenie poziomów
- Wdrożenie elementów RPG do gry(dłuższy skok, więcej żyć, nieśmiertelność na chwilę, umiejętność latania...)
- Charakteryzacja swojej postaci(kilka modeli żab?)
- mini-tryby typu nightmare(ucieczka z labiryntu(goni nas inna żaba?)

### Przy tworzeniu projektu wykorzystałem:

///////////////////////////////////////////////////////////////////////////
- **grafiki** do projektu z następującej strony:

> http://tinyurl.com/yc3b4zxn
///////////////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////////////////////
- **poruszanie** za pomocą klawiszologii:

> http://tinyurl.com/yd8eetvq
///////////////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////////////////////
- **poruszanie**, postać, itd...

> http://tinyurl.com/ycqbljmo
///////////////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////////////////////
- idea związana z **paskiem postępu** wziąłem stąd:

> http://tinyurl.com/ycu8axml
///////////////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////////////////////
- **dźwięk żaby** (jego inne barwy zostały zedytowane w programie **Audacity**)

> http://tinyurl.com/y9dba82z
///////////////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////////////////////
- **rozwiązanie problemu** pictureboxów, które nie były przezroczyste(mimo, że były w png i nie miały tła) po dodaniu do projektu i ustawienia tła na przezroczyste.. a dzięki tej opcji poniżej działają jak trzeba.

> https://tinyurl.com/y7d9fskb
///////////////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////////////////////
- animacja żaby, znaleziona w google grafice....
///////////////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////////////////////
- **projekt** tła wykonany przy pomocy programu photoshopo'podobnego pixlr, link:

> http://tinyurl.com/6pbyskv
///////////////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////////////////////
- **rozwiazanie problemu** kolizji z pojazdami tutaj znalazłem:

> http://tinyurl.com/y99booh9
///////////////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////////////////////
- jak sprawić żeby okienka nie można było **skalować**:

> https://tinyurl.com/yb5vjevo
///////////////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////////////////////
- jak usunąć przycisk zamknięcia aplikacji

> https://tinyurl.com/yawgggve
///////////////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////////////////////
- jak skopiować formę?

> https://tinyurl.com/y9j5pl6z
///////////////////////////////////////////////////////////////////////////


###########################################################################