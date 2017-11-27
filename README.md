###########################################################################


# Projekt F.R.O.G
## Projekt w stylu klasycznej, arcade'owej gry -> 'Frogger'.


###########################################################################
* Data rozpoczęcia: 18.11.17
* Data zakończenia(mechanika): 25.11.17 
* Instrukcja zamieszczona w grze.
* Wykorzystany język: C#
* Wykonanie w: WinForms, Visual Studio 2017 

#Wpis dodatkowy z 27.11.17
Nie mam zielonego pojęcia co się dzisiaj stało... jest tak późno, że jutro dopiero to opiszę pewnie, ale
nie wierzę... 


Podsumowanie po skończeniu całej mechaniki:

Na moje nieszcżęście dopiero pod koniec projektu, to znaczy **podczas procesu tworzenia kłód**, które
będą pływały po wodzie zauważyłem..., że timery(czasomierze) renderują moje pictureboxy troszkę
wolno i kłody i pojazdy dość wolno "lecą"... Ku mojemu **rozczarowaniu**.. Naczytałem sobie o tej kwestii na 
stackoverflow i okazało się, że WinForms to **nie jest dobra opcja do tego aby
tworzyć grę**.... No ale cóż... przed poruszaniem kłodami samochody jeździły
*i-d-e-a-l-n-i-e*!!.... Nie wziąłem pod uwagę opcji, że większa ilość pictureboxów do 
renderowania spowolni tempo działania tych obiektów, które zmieniają swoje położenie... 
no ale cóż... Na następny raz będę wiedział aby nie zabierać się do gry w WinForms...
(w szczególności do takiej bardziej rozbudowanej w stylu RPG czy coś).

No i oczywiście gdy zakomentuje ruch kłód to pojazdy pięknie jeżdzą....
Zastanawiałem się nad tym czy ich nie usunąć i nie dać kolejnego pasa
ruchu dla pojazdu i dać kolejny pojazd... Pewnie to by upłynniło rozgrywkę,
jednak pomyślałem, że nie robie tego projektu dla tego aby mieć 30 FPS na 
ekranie a aby czegoś się nauczyć, więc chyba jednak zostane przy kłodach bo
dzięki nim dodana została mechanika, która wykrywa czy żaba weszła na wode
czy jest na gałęźi. 

Pozostał jeszcze problem, który rzucał mi się w oczy:
W momencie gdy gracz przytrzyma przycisk ruchu, wszystkie pozostałe 
pictureboxy **zatrzymują się**, to znaczy np. żaba może przenikać przez 
samochody bez utraty życia itd... :(

Poniżej umieszczam linki z których korzystałem podczas tworzenia projektu. 
Pewnie do nich sam zajrzę jak zapomnę co jak zrobić w C#(albo wpisze do google...).
Polecam te liniki, dzięki nim szybko pojąłem jak co zrobić, np. taki ruch pictureboxa itd..

###########################################################################


### Przy tworzeniu projektu wykorzystałem:


- **grafiki** do projektu z następującej strony:

> http://tinyurl.com/yc3b4zxn



- **poruszanie** za pomocą klawiszologii:

> http://tinyurl.com/yd8eetvq



- **poruszanie**, postać, itd...

> http://tinyurl.com/ycqbljmo



- idea związana z **paskiem postępu** wziąłem stąd:

> http://tinyurl.com/ycu8axml



- **dźwięk żaby** (jego inne barwy zostały zedytowane w programie **Audacity**)

> http://tinyurl.com/y9dba82z



- **rozwiązanie problemu** pictureboxów, które nie były przezroczyste(mimo, że były w png i nie miały tła) po dodaniu do projektu i ustawienia tła na przezroczyste.. a dzięki tej opcji poniżej działają jak trzeba.

> https://tinyurl.com/y7d9fskb



- **animacja żaby*, znaleziona w google grafice...., nie mogłem znaleźć linka :( .




- **projekt** tła wykonany przy pomocy programu photoshopo'podobnego pixlr, link:

> http://tinyurl.com/6pbyskv



- **rozwiazanie problemu** kolizji z pojazdami tutaj znalazłem:

> http://tinyurl.com/y99booh9



###########################################################################