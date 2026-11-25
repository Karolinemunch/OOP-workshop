Group members: 

Karoline
Frederik
David
Jeppe

GG

//UML-diagrammer


classDiagram
    Material <|-- E-book
    E-book : -String author
    E-book : -String language
    E-book : -int numberOfPages
    E-book : -int yearOfPublication
    E-book : -String ISBN

    Material <|-- Movie
    Movie : -String director
    Movie : -String genre
    Movie : -int releaseYear
    Movie : -String language
    Movie : -String duration

    Material <|-- Image
    Image : -String resolution
    Image : -String fileFormat
    Image : -String fileSize
    Image : -String dateTaken

    Material <|-- Song
    Song : -String composer
    Song : -String singer
    Song : -String genre
    Song : -String fileType
    Song : -String duration
    Song : -String language

    Material <|-- App
    App : -String version
    App : -String publisher
    App : -String supportedPlatforms
    App : -String fileSize

    Material <|-- Podcast
    Podcast : -int releaseYear
    Podcast : -String hosts
    Podcast : -String guests
    Podcast : -int episodeNumber
    Podcast : -String language

    Material <|-- Videogame
    Videogame : -String genre
    Videogame : -String publisher
    Videogame : -int releaseYear
    Videogame : -String supportedPlatforms

    Material : -String title
    Material : -double rating
    Material : -bool IsBorrowed
    Material: +Download()
    Material: +ShowInfo()

    class Viewable <<Interface>>
    Viewable <|-- E-book
    Viewable <|-- Image
    Viewable : +View()
    
    class Playable <<Interface>>
    Playable <|-- Videogame
    Playable <|-- Song
    Playable <|-- Movie
    Playable <|-- Podcast
    Playable <|-- Play
    Playable : +Play()

    class User <<Abstract>>
    User : -String name
    User : -String CPR
    User : -int age
    User : -list~Material~ borrowHistory
    User : -list~Material~ currentlyBorrowed
    User: Review()
    User: Download()

    User <|-- Borrower
    
    User <|-- Employee 
    Employee: AddMaterial()
    Employee: RemoveMaterial()

    
    Employee <|-- Admin
    Admin: ChangeRole()
    Admin: ChangeCPR()
    Admin: ChangeName()
    Admin: ChangeAge()
    Admin: RemoveReview()


    Borrower : -List~Material~ Borrowed

    class Library 
    Library : -list~Material~ library

    Library: +BorrowedCheck()
    Library: +ViewLibrary()