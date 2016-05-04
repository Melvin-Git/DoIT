# Git Bash Cheatsheet #

## Index ##



> **2. Konfiguration**

> > ***2.1 Identität bearbeiten***

> > ***2.2 Texteditor aktivieren (VIM)***

> > ***2.3 Diff Programm auswählen (VIM Diff)***

> > ***2.4 Einstellungen auflisten***

> ---

> **3. Git Repository**

> > ***3.1. Neues Repository anlegen***

> > ***3.2. Repository klonen***

> > ***3.3. Dateien zur Versionskontrolle hinzufügen***

> ---

> **4. Status**

> > ***4.1. Datei zur Versionskontrolle hinzufügen***

> > ***4.2. Datei nach Bearbeitung 'stagen'***

> > ***4.3. Datei(en) committen***

> > ***4.4. Commithistorie***

> > ***4.5. Filterung der Log Daten***

> > ***4.6. Status des Repositorys prüfen***

> > ***4.7. Den letzten Commit ändern***

> > ***4.8. Änderungen aus der Staging Area entfernen***

> ---

> **5. Dateien / Ordner verwalten**

> > ***5.1. Neue Datei erstellen***

> > ***5.2. Neuen Ordner erstellen***

> > ***5.3. Datei löschen***

> > ***5.4. Ordner löschen***

> > ***5.5. Datei aus der Versionskontrolle nehmen***

> > ***5.6. Datei umbenennen / verschieben***

> > ***5.7. Die Version des letzten Commits der Datei aufrufen***

> ---

> **6. Tags**

> > ***6.1. Kommentierte Tags***

> > ***6.2. Einfache Tags***

> ---

> **7. Branching**

> > ***7.1. Master-Branch***

> > ***7.2. Neuen Branch erstellen***

> > ***7.3. Branch löschen***

> > ***7.4. HEAD***

> > ***7.5. Merging***

> > ***7.6. Branches anzeigen***

> > ***7.7. Letzten Commit der verschiedenen Branches anzeigen***

> > ***7.8. Zusammengeführte Branches anzeigen***

> ---

## Konfiguration ##

Hier sind die wichtigsten Befehle zu den Standardeinstellungen:

> Um die Konfiguration zu bearbeiten wird die Kommandozeile **git config** verwendet.

> ---

> ### Identität bearbeiten ###
>     $ git config --global user.name "Melvin Lupp"
>     $ git config --global user.email melvin.lupp@ch.schindler.com

> ---

> ### Texteditor aktivieren (VIM)
>     $ git config --global core.editor vim

> ---

> ### Diff Programm auswählen (VIM Diff)
>     $ git config --global merge.tool vimdiff

> ---

> ### Einstellungen auflisten ###
>     $ git config --list

> ---
 
Falls man irgendwann mal einen command vergisst, kann man in git auf 2 Arten eine Hilfeabfrage zum entsprechenden Element, wie z.B. git config senden:

    $ git help config
	$ git config --help

Wenn man einen dieser Befehle eingibt, werden dazugehörige Commands aufgelistet.


## Git Repository

Genau wie in der cmd Befehlsbox, kann man in bash mit dem Befehl `cd <Pfad>` das Verzeichnis wechseln.
 
> ### Neues Repository anlegen ###
>     $ git init <Repository Namen>
> Dieser Befehl legt ein neues *lokales* Repository an.

>     $ git remote
>     
> ---

> ### Repository klonen ###
>     $ git clone <Pfad zum Repository>
>     $ git clone <Pfad zum Repository> <neuer Name für Kopie>

> ---

> ### Dateien zur Versionskontrolle hinzufügen ###
>     $ git add <Dateiname / Pfad zur Datei>

> ---
>
## Status ##

Eine Datei kann sich in verschiedenen Zuständen befinden; untracked (nicht in der Versionskontrolle), unmodified (seit dem letzten Commit nicht mehr bearbeitet), modified (Datei wurde bearbeitet, aber noch nicht für Commit bereitgestellt), staged (Eine Datei wurde für den Commit vorbereitet).

![](http://git-scm.com/figures/18333fig0201-tn.png)

> ### Datei zur Versionskontrolle hinzufügen ###
>     $ git add <Dateiname>

> ---

> ### Datei nach Bearbeitung 'stagen' ###
>     $ git add <Dateiname>

> ---

> ### Datei(en) committen ###
>     $ git commit
> Nach diesem Befehl öffnet sich das VIM und man kann seinen Kommentar zum Commit (Snapshot) dazuschreiben. Ein Commit bedeutet, dass eine oder mehrere Dateien Versioniert werden.

>     $ git commit -a
> Das `-a` bedeutet, dass man die Staging area überspringt. Die Dateien, welche sich unter der Versionskontrolle befinden, werden so committed, wie sie im Augenblick sind, und nicht, wie sie waren, als sie das letzte mal geadded wurden.
 
> ---

> ### Commithistorie ###
> Wenn man bereits einige Commits gemacht hat, kann man sich die Commithistorie ansehen. Diese kann man in verschiedenen Formaten anschauen.

>     $ git log
> `git log` zeigt die Checksummen der Commits an, den Autor (und die email-Adresse) und einen Zeitstempel.

>     $ git log -p
> Diese Option erweitert `git log`, indem sie anzeigt, was für Änderungen zeilenweise an den Dokumenten vorgenommen wurden.

>     $ git log -2
> Hier werden nur die logs der letzten 2 Commits angezeigt. Man kann eine beliebige Zahl schreiben, es werden so viele logs angezeigt, wie man verlangt.

>     $ git log -p --word-diff
> Dies ist eine Erweiterung von `git log -p`. Man kann damit die Änderungen der einzelnen Wörter statt die der Zeilen nachverfolgen. Dies ist eine gute Erweiterung für längere Textdateien.

>     $ git log --stat
> Dieser Command bewirkt, dass zu jedem Commit eine kurze Statistik angezeigt wird, die zeigt, wie viele Dateien / Zeilen gelöscht oder hinzugefügt wurden.

>     $ git log --pretty
> Mit dem Begriff `--pretty` kann man das Format des Commit-Logs selbst beeinflussen. Man kann nach dem Command das Format setzen:

> * `git log --pretty=oneline` -> Alle Commits werden mit dem Hash und dem Kommentar auf 1 Linie angezeigt.
> * `git log --pretty=format:"%h - %an, %ar : %s` -> die Option `format` bedeutet, dass man sich den Log selbst zusammenstellen kann. Bei dem obigen Beispiel wird der Commit so angezeigt:

>     `HashNr - Autor Name, Änderungsdatum (z.B. 3 months ago) : Commit-Kommentar`

>      Eine Zusammenstellung der `format`-Optionen findet man auf dieser Seite:
>      
>      [http://git-scm.com/book/de/Git-Grundlagen-Die-Commit-Historie-anzeigen](http://git-scm.com/book/de/Git-Grundlagen-Die-Commit-Historie-anzeigen)

> ---

> ### Filterung der Log Daten ###
>     $ git log --since=2.weeks
> Die Option `--since=<>.<>` lässt alle Logdaten der letzten 2 Wochen anzeigen.

>     $ git log --until=2.weeks
> Dies ist das Gegenteil der `since`-funktion. Es werden alle Logdaten angezeigt, die länger her sind als 2 Wochen.

> Man kann auch ein Datum eingeben, z.B. `2008-01-15`.
      

> ---
 
> ### Status des Repositorys prüfen ###
>     $ git status
> Mit diesem Befehl wird ausgegeben, welche Dateien in welchem Status sind.

>     $ git diff
> Mit diesem Befehl kann man genau sehen, was sich in welchem Dokument verändert hat. Allerdings zeigt er nur die Änderungen an, welche noch nicht für den nächsten Commit vorbereitet wurden.
>     $ git diff --cached
> Mit diesem Befehl kann man genau sehen, was sich in welchem Dokument verändert hat. Allerdings zeigt er nur die Änderungen an, welche bereits für den nächsten Commit vorbereitet wurden.

> ---

> ### Den letzten Commit ändern ###
>     $ git commit --amend
> **Achtung:** Wenn man hier einen Fehler macht, kann es sein, dass man Daten verliert!

> Falls man den letzten Commit angelegt hat, und de Commitmeldung oder eine Datei falsch angegeben oder vergessen hat, kann man das vergessene File adden. Danach kann man den Befehl `git commit --amend` ausführen und man kann normal im VIM den Commit Betreff ändern.

> ---

> ### Änderungen aus der Staging Area entfernen ###
>     $ git reset HEAD <dateiname>
> Mithilfe dieses Befehls kann man geaddete Dateien wieder aus der Staging Area herausnehmen, ohne, dass man sie gleich aus der Versionskontrolle entfernen muss.

> ---

## Dateien / Ordner verwalten ##

> ### Neue Datei erstellen ###
>     $ touch <Dateiname>

> ---

> ### Neuen Ordner erstellen ###
>     $ mkdir <ordnername>

> ---

> ### Datei löschen ###
>     $ rm <dateiname>

> ---

> ### Ordner löschen ###
>     $ rmdir <ordnername>

> ---

> ### Datei aus der Versionskontrolle nehmen ###
>     $ rm --cached <dateiname>

> ---

> ### Datei umbenennen / verschieben ###
>     $ git mv <bisheriger dateiname> <neuer dateiname>
> Dieser Befehl benennt eine Datei um.

>     $ git mv <dateiname> <ordnername/dateiname>
> Dieser Befehl verschiebt die Datei in einen Unterordner.

> *Beim verschieben in einen anderen Ordner, wird beim ausführen von `git status` die Datei ebenfalls als 'renamed' eingetragen, obwohl sie nur verschoben wurde.*

> ---

> ### Die Version des letzten Commits der Datei aufrufen ###
> Dies ist ein sehr wichtiger Punkt. Wenn man eine Datei abgespeichert hat, allerdings die Änderungen nicht gut findet und wieder zu einer früheren Version der Datei zurück will, kann man mit der folgenden Kommandozeile die Version wiederherstellen:

>     $ git checkout -- <dateiname>

> ---

## Tags ##

Ein Tag ist eine Markierung für einen Commit. Man kann sozusagen Lesezeichen setzen. Wenn man einen Commit erstellt hat, welchen man sehr wichtig findet, kann man gleich nachdem man den Commit durchgeführt hat einen Tag setzen. Wenn man einige Commits später wieder an diese Stelle zurückkehren will, kann man mit dem Befehl `git checkout <Tagname>` wieder dort hin gelangen.
Im Source Tree wird das sehr deutlich und einfach dargestellt, man kann einen Commit auswählen, für welchen man einen Tag hineinschreibt. Nachdem man den Befehl mit `checkout` durchgeführt hat, sieht man, dass der Zeiger HEAD auf diesen Commit zurückgesprungen ist.

> ### Kommentierte Tags ###
>     $ git tag -a <Versionenname> -m '<Kommentar>
> Diesen Befehl braucht man z.B. wenn man einen Commit umfangreich markieren möchte. Er zeigt die Checksumme, den Namen und die Email Adresse des Autors.

> ---

> ### Einfache Tags ###
>     $ git tag <Versionenname>
> Tag zeigt nur Prüfsumme an, welche dem Commit gehört, zu dem der Tag verweist.

> ---

## Branching ##

Unter einem Branch versteht man einen Zeiger, welcher auf einen Commit zeigt.

> ### `Master`-Branch ###
> Ein Master Branch verweist auf den letzten erstellten Snapshot.

> ---

> ### Neuen Branch erstellen ###
>     $ git branch <Branchname>
> Wenn man allerdings einen neuen Branch erstellen will, und gleichzeitig darauf zugreifen möchte, kann man folgende Option benutzen:

>     $ git checkout -b <Branchname>

> ---

> ### Branch löschen ###
>     $ git branch -d <Branchname>
> Mit diesem Befehl kann man ein Branch wieder löschen. Dies funktioniert allerdings nur, wenn man sich nicht gerade auf diesem Branch befindet, d.h. Man muss zuerst auf ein anderes Branch wechseln, bevor man das Branch löschen kann

>     $ git branch -D <Branchname>
> Falls sich in diesem Branch noch Committete Dateien befanden, die noch nicht gemerged wurden, wird nach dem Versuch mit `git branch -d` eine Fehlermeldung kommen, nämlich diese:

>     error: The branch '<branchname>' is not fully merged.
>     If you are sure you want to delete it, run 'git branch -D <branchname>'.

> Wenn du aber alle Änderungen auf diesem Branch verwerfen möchtest (auch die Committeten), kannst du mit dem Befehl `git branch -D` fortfahren.

> ---

> ### HEAD ###
> Bei HEAD handelt es sich um einen Zeiger auf den aktuell ausgewählten Branch. Der HEAD-Zeiger zeigt standardmässig immer auf den Master, egal, ob man selbst einen Branch erstellt hat. Um den aktuellen Branch zu wechseln, d.h. um den HEAD zeiger auf einen anderen Branch zu lenken, kann man den folgenden Befehl verwenden:

>     $ git checkout <Branchname>

> *Beispiel mit dem Branch "Testing":*

>     $ git branch testing

> ![](http://git-scm.com/figures/18333fig0305-tn.png)

>     $ git checkout testing

> ![](http://git-scm.com/figures/18333fig0306-tn.png)

>     $ git commit -a -m '
 
> ![](http://git-scm.com/figures/18333fig0307-tn.png)

> Nun kann man zum Master-Branch zurückkehren, was man wieder mit dem `checkout` Objekt macht. Nun sind vorübergehend alle Dateien in dem Arbeitsverzeichnis wieder auf die Version zurückgestellt, auf die das Master-Branch zeigt. Man kann also von diesem Zustand aus wiederum einige andere Änderungen vornehmen. Wenn man diese nun wieder Committed, passiert folgendes:

> ![](http://git-scm.com/figures/18333fig0309-tn.png)

> Die Versionen verzweigen sich. Man kann also an demselben Projekt arbeiten, aber völlig verschiedene Änderungen machen. Später kann man die Versionen wieder zusammenführen.

> ---

> ### Merging ###
>     $ git merge <Branchname>
> Mit Hilfe dieses Befehls kann man die verschiedenen Versionen einer / oder mehrerer Dateien zusammenführen. Ein Beispiel wäre:

> **Dokument auf Master Branch:**

> > Dies ist eine Zusammenfassung zum Thema Git und den wichtigsten Kommandos.
> > Source Tree wird hier erklärt, ist aber einfach zu verstehen, wenn man mit dem Kommandozeilentool umgehen kann.

> Plötzlich merkt man, dass im 2. Satz ein Wort fehlt.

> **Dokument auf Branch test1**

> > Dies ist eine Zusammenfassung zum Thema Git und den wichtigsten Kommandos.
> > Source Tree wird hier NICHT erklärt, ist aber einfach zu verstehen, wenn man mit dem Kommandozeilentool umgehen kann.

> Wenn man nun beide Versionen auf den jeweiligen Branches Committed, kann man via `git checkout master` wieder vom test1 Branch zu Master wechseln. Nun kann man den `git merge test1` Befehl ausführen. Das bedeutet, dass die Committeten Versionen von test1 nun in die Versionen von Master einfliessen. Nun wird logischerweise die neue Version in Master genau gleich aussehen wie in test1, da lediglich das Wort "NICHT" eingefügt wurde. Wenn man allerdings mal mehrere Sachen in ein Dokument schreibt, kann diese Option sehr nützlich sein.

> ---

> ### Branches anzeigen ###
>     $ git branch
> Dies zeigt eine Liste mit allen aktuellen Branches. Das Branch, vor dem ein * steht, ist das aktuell benutzte Branch, auf das der HEAD Zeiger zeigt.

> ---

> ### Letzten Commit der verschiedenen Branches anzeigen ###
>     $ git branch -v
> Mit diesem Befehl wird der letzte Commit mit dem Hash und dem Betreff von jedem Branch angezeigt.

> <img src ="C:\Users\luppme\Pictures\git\git_branch_-v.png" title="Zeigt letzten Commit von jedem Branch" />

> ---

> ### Zusammengeführte Branches anzeigen ###
>     $ git branch --merged
> Bei diesem Befehl wird angezeigt, welche Branches in den aktuell ausgewählten Branch gemerged wurden.

>     $ git branch --no-merged
> Um Branches auflisten zu lassen, welche noch nicht in den aktuellen Branch gemerged wurden, kann man diesen Befehl auswählen.

> <img src="C:\Users\luppme\Pictures\git\git_branch_merged_no-merged.png" title="Zeigt zusammengeführte / nicht zusammengeführte Branches" />

> ---

## Branching Workflows ##

> ### Langfristige Branches ###

> Unter langfristigem Branching versteht man die Existenz von mehreren Branches, welche man alle gleichzeitig Verwenden kann, die jedoch alle auf verschiedenen Ebenen ihren Platz haben. Mann kann sich das besser vorstellen, wenn man diese Grafik betrachtet:

> ![](http://git-scm.com/figures/18333fig0319-tn.png)

> Hier werden 3 Branches dargestellt; *master, develop und topic*.
> Auf dem Master Branch befindet sich nur ein einziger Commit. Auf den anderen beiden Branches jedoch findet man mehrere Commits, die von einander abhängig sind. So sind die Commits auf der Ebene *topic* viel instabiler, als die Commits auf den höheren Ebenen. Die Commits in *topic* wurden erst gerade erstellt. Sobald man einen Commit für stabil genug hält, um mit der Version aus einer höheren Ebene zusammenzuarbeiten, werden diese Branches gemerged. Dieses Prinzip wird oft verwendet, wenn man z.B. auf dem master-Branch nur die Version des Projektes haben will, die man veröffentlicht. Die unteren Ebenen sind nur zum Test da. 

> >**Kurzfassung:**
 
> >In langfristigen Branches werden meist mehrere Ebenen verwendet, welche man zur selben Zeit bearbeiten kann, und je nach Stabilitätsstufe mit einer höheren Ebene zusammenführt.

> ---

> ### Themen Branches ###
> Themenbranches sind kurzzeitig erstellte Branches, welche nur für einen ganz bestimmten Abschnitt eines Projekts eingesetzt werden. Wenn sie gut sind, kann man sie mit dem Master Branch zusammenführen und anschliessend wieder löschen.

> ![](http://git-scm.com/figures/18333fig0320-tn.png)

> ---

