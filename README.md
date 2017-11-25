###########################################################################


# Projekt Frog
## Projekt gry w stylu żaby.


###########################################################################
* Data rozpoczęcia: 18.11.17
* Instrukcja w grze.
* Wykorzystany język: C#
* Wykonanie w: WinForms


Podsumowanie:

Niestety dopiero pod koniec projektu, to znaczy **podczas procesu tworzenia kłód**, które
będą pływały po wodzie zauważyłem, że timery renderują moje pictureboxy strasznie
wolno i gra ciut muli.. ku mojemu **rozczarowaniu**.. Naczytałem sobie o tym na 
stackoverflow i okazało się, że WInForms to **nie jest dobra opcja do tego aby
tworzyć grę**.... No ale cóż... przed poruszaniem kłodami samochody jeździły
idealnie.... Nie przewidziałem tego... no ale cóż... Na następny raz
będę wiedział aby nie zabierać się do gry w WinForms...
(w szczególności do takiej bardziej rozbudowanej w stylu RPG).

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

> https://stackoverflow.com/questions/5522337/c-sharp-picturebox-transparent-background-doesnt-seem-to-work



- **animacja żaby*, znaleziona w google grafice, nie mogłem znaleźć linka.



- **projekt** tła wykonany przy pomocy programu photoshopo'podobnego pixlr, link:

> http://tinyurl.com/6pbyskv



- **rozwiazanie problemu** kolizji z pojazdami tutaj znalazłem:

> http://tinyurl.com/y99booh9



###########################################################################