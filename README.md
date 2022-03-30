# FinalProgram-9
Instructions: Part 1 (Abstract Classes)

Create a new directory, Models. Within it, create model equivalents to your Itunes project beginning with Song (int Id, string Title).

Create an abstract class, User (int Id, string Name, List<Song> Collection, string email). 

Create for User the method GenerateEmail, which appends their ID to their Name to generate an email for them.

Create the classes Artist and Customer to implement User. What do you need to add to these classes to have them inherit properly from User?

Add the ArtistId, Artist, and Customers properties to Song.

Have the Artist override the GenerateEmail method to prepend an A to the email generated in the base class.

Instructions: Part 2 (Interfaces)

Expand our system to allow for the use of different media types. Create the interface, iMedia, with the properties Title, Runtime, and the method Play. 

Modify the Collection property of User to collect iMedia objects rather than Songs.

Implement iMedia as Song and Video classes. When a Song invokes Play() it should log “Playing the song [Title] on your favourite music platform for [Runtime].” When a Video invokes Play() it should log “Watching [Title] on your inadequate viewing screen for [Runtime].” 

Provide User a method, Binge, which invokes Play() on each object in their Collection. This requires no logic beyond looping through every iMedia object and invoking iMedia.Play();
