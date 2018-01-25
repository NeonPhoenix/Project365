# Project365

This repo is a coding project for myself.
Starting on 1st January 2018, I will attempt to program each solution listed below for each day of the year.
Obviously most solutions will need a couple of days to figure out. However the main goal is to make sure that a solution is uploaded each day throughout the entire year.
New solutions will be added throughout the year.

Project ideas were obtained from [Karan Project Solutions](https://github.com/karan/Projects-Solutions), [Rosetta Code](http://rosettacode.org/wiki/Category:Programming_Tasks) and [martyr2s mega project idea list](http://www.dreamincode.net/forums/topic/78802-martyr2s-mega-project-ideas-list/).

## Numbers
- [x] Find Pi to the Nth digit.
	- Enter a number and have the program generate PI up to that many decimal places. Keep a limit to how far the program will go.
- [x] Find e to the Nth digit.
	- Just like the previous problem, but with e instead of PI. Enter a number and have the program generate e up to that many decimal places. Keep a limit to how far the program will go.
- [x] Fibonacci sequence
	- Enter a number and have the program generate the Fibonacci sequence to that number or to the Nth number.
- [x] Prime factorization
	- Have the user enter a number and find all Prime Factors (if there are any) and display them.
- [x] Next prime number
	- Have the program find prime numbers until the user chooses to stop asking for the next one.
- [x] Find cost of tile to cover W x L floor.
	- Calculate the total cost of tile it would take to cover a floor plan of width and height, using a cost entered by the user.
- [x] Mortgage calculator.
	- Calculate the monthly payments of a fixed term mortgage over given Nth terms at a given interest rate. Also figure out how long it will take the user to pay back the loan. For added complexity, add an option for users to select the compounding interval (Monthly, Weekly, Daily, Continually).
- [x] Change return program.
	- The user enters a cost and then the amount of money given. The program will figure out the change and the number of quarters, dimes, nickels, pennies needed for the change.
- [x] Binary to decimal and back converter.
	- Develop a converter to convert a decimal number to binary or a binary number to its decimal equivalent.
- [ ] Calculator
	- A simple calculator to do basic operators. Make it a scientific calculator for added complexity.
- [ ] Unit converter (Temp, Currency, Volume, Mass and more)
	- Converts various units between one another. The user enters the type of unit being entered, the type of unit they want to convert to and then the value. The program will then make the conversion.
- [ ] Alarm clock
	- A simple clock where it plays a sound after X number of minutes/seconds or at a particular time.
- [ ] Distance between two cities
	- Calculates the distance between two cities and allows the user to specify a unit of distance. This program may require finding coordinates for the cities like latitude and longitude.
- [ ] Credit Card validator
	- Takes in a credit card number from a common credit card vendor (Visa, MasterCard, American Express, Discover) and validates it to make sure that it is a valid number (look into how credit cards use a checksum).
- [ ] Tax calculator
	- Asks the user to enter a cost and either a country or state tax. It then returns the tax plus the total cost with tax.
- [ ] Factorial finder
	- The factorial of a positive integer n is defined as the product of the sequence , n-1, n-2, ...1 and the factorial of 0 is defined as being 1. Solve this using both loops and recursion.
- [ ] Complex number algebra
	- Show addition, multiplication, negation, and inversion of complex numbers in separate functions. (Subtraction and division operations can be made with pairs of these operations.) Print the results for each operation tested. 
- [ ] Happy numbers
	- A happy number is defined by the following process. Starting with any positive integer, replace the number by the sum of the squares of its digits, and repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1. Those numbers for which this process ends in 1 are happy numbers, while those that do not end in 1 are unhappy numbers. Display an example of your output here. Find first 8 happy numbers.
- [ ] Number names
	- Show how to spell out a number in English. You can use a preexisting implementation or roll your own, but you should support inputs up to at least one million (or the maximum value of your language's default bounded integer type, if that's less). Optional: Support for inputs other than positive integers (like zero, negative integers, and floating-point numbers).
- [ ] Coin flip simulation
	- Write some code that simulates flipping a single coin however many times the user decides. The code should record the outcomes and count the number of tails and heads.
- [ ] Fast exponentiation
	- Ask the user to enter 2 integers a and b and output a^b (i.e. pow(a,b)) in O(lg n) time complexity. 
- [ ] 99 Bottles of Beer
	- Display the complete lyrics for the song: 99 Bottles of Beer on the Wall. Grammatical support for "1 Bottle of Beer" is optional.
- [ ] ABC Problem
	- Write a function that takes a string (word) and determine whether the word can be spelled with the given collention of blocks. The rules are simple: 1 - Once a letter on a block is used that block cannot be used again. 2 - The function should be case-insensitive.
	
## Classic Algorithms
- [ ] Collatz conjecture
	- Start with a number n > 1. Find the number of steps it takes to reach one using the following process: If n is even, divide it by 2. If n is odd, multiply it by 3 and add 1.
- [ ] Sorting
	- Implement two types of sorting algorithms: Merge sort and bubble sort
- [ ] Closest pair
	- The closest pair of points problem or closest pair problem is a problem of computational geometry: given n points in metric space, find a pair of points with the smallest distance between them.
- [ ] Sieve of Eratosthenes
	- The sieve of Eratosthenes is one of the most efficient ways to find all of the smaller primes (below 10 million or so).

## Graphs
- [ ] Graph from links
	- Create a program that will create a graph or network from a series of links.
- [ ] Eulerian path
	- Create a program which will take as an input a graph and output either a Eulerian path or a Eulerian cycle, or state that it is not possible. A Eulerian Path starts at one node and traverses every edge of a graph through every node and finishes at another node. A Eulerian cycle is a eulerian Path that starts and finishes at the same node.
- [ ] Connected graph
	- Create a program which takes a graph as an input and outputs whether every node is connected or not.
- [ ] Djikstra's algorithm
	- Create a program that finds the shortest path through a graph using its edges.
- [ ] Minimum spanning tree
	- Create a program which takes a connected, undirected graph with weights and outputs the minimum spanning tree of the graph i.e., a subgraph that is a tree, contains all the vertices, and the sum of its weights is the least possible.

## Data Structures
- [ ] Inverted Index
	- An Inverted Index is a data structure used to create full text search. Given a set of text files, implement a program to create an inverted index. Also create a user interface to do a search using that inverted index which returns a list of files that contain the query term / terms. The search index can be in memory.

## Text
- [ ] Fizz Buzz
	- Write a program that prints the numbers from 1 to 100. But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. For numbers which are multiples of both three and five print “FizzBuzz”.
- [ ] Reverse a string
	- Enter a string and the program will reverse it and print it out.
- [ ] Pig latin
	- Pig Latin is a game of alterations played on the English language game. To create the Pig Latin form of an English word the initial consonant sound is transposed to the end of the word and an ay is affixed (Ex.: "banana" would yield anana-bay). Read Wikipedia for more information on rules.
- [ ] Count Vowels
	- Enter a string and the program counts the number of vowels in the text. For added complexity have it report a sum of each vowel found.
- [ ] Check if Palindrome
	- Checks if the string entered by the user is a palindrome. That is that it reads the same forwards as backwards like “racecar”
- [ ] Count words in a string
	- Counts the number of individual words in a string. For added complexity read these strings in from a text file and generate a summary.
- [ ] Fortune Teller
	- A program that checks your horoscope on various astrology sites and puts them together for you each day.
- [ ] Vigenere / Vernam / Ceasar Ciphers
	- Functions for encrypting and decrypting data messages. Then send them to a friend. 
- [ ] Random Gift Suggestions
	- Enter various gifts for certain people when you think of them. When its time to give them a gift (xmas, birthday, anniversary) it will randomly pick one. Optional: Suggest places you can get it (link to Amazon page?).
- [ ] Regex query tool
	- A tool that allows the user to enter a text string and then in a separate control enter a regex pattern. It will run the regular expression against the source text and return any matches or flag errors in the regular expression. 
- [ ] Markdown to HTML Converter
	- Converts Markdown formatted text into HTML files. Implement basic tags like p, strong, em etc. Optional: Implement all tags from Markdown Syntax Docs.
- [ ] CD key generator
	- Generates a unique key for your applications to use based on some arbitrary algorithm that you can specify. Great for software developers looking to make shareware that can be activated.
	
## Networking
- [ ] FTP Program
	- A file transfer program which can transfer files back and forth from a remote web sever.
- [ ] Bandwidth monitor
	- A small utility program that tracks how much data you have uploaded and downloaded from the net during the course of your current online session. See if you can find out what periods of the day you use more and less and generate a report or graph that shows it.
- [ ] Port scanner
	- Enter an IP address and a port range where the program will then attempt to find open ports on the given computer by connecting to each of them. On any successful connections mark the port as open.
- [ ] Country from IP Lookup
	- Enter an IP address and find the country that IP is registered in. Optional: Find the Ip automatically.
- [ ] Whois search tool
	- Enter an IP or host address and have it look it up through whois and return the results to you. 
- [ ] Get atomic time from internet clock
	- This program will get the true atomic time from an atomic time clock on the Internet. Use any one of the atomic clocks returned by a simple Google search.
- [ ] Packet sniffer
	- A utility program that will read packets coming in and out of the machine along with related information like destination and payload size.
- [ ] Web bot
	- An automated program which carries out tasks on the web including checking websites, page scraping, and summarization of data or web posting.
- [ ] Telnet Application
	- Create an application which can telnet into servers across the internet and run basic commands.
	
## Threading
- [ ] Create a progress bar for downloads
	- Create a progress bar for applications that can keep track of a download in progress. The progress bar will be on a separate thread and will communicate with the main thread using delegates.
- [ ] Fetch current weather
	- Get the current weather for a given zip/postal code. Optional: Try locating the user automatically.
- [ ] Download manager
	- Allow your program to download various files and each one is downloading in the background on a separate thread. The main thread will keep track of the other thread’s progress and notify the user when downloads are completed.
- [ ] Chat application
	- Create a chat application which allows you to connect directly to another computer by their IP through the use of remoting and allow your “server” application handle multiple incoming connections.

## Databases
- [ ] Baseball / Other Card Collector
	- Create an online application for keeping track of a collection of cards. Let the user enter all cards in a set, check off which ones they have, which ones they need and generate lists of cards they are looking for. For extra complexity, have it sum up sets and generate reports on how close they are of completing sets or the current value of a set.
- [ ] Report Generator
	- Create a utility that generates a report based on some tables in a database. Generates a sales reports based on the order/order details tables or sums up the days current database activity.
- [ ] Budget Tracker
	- Write an application that keeps track of a household’s budget. The user can add expenses, income, and recurring costs to find out how much they are saving or losing over a period of time. For added complexity allow the user to specify a date range and see the net flow of money in and out of the house budget for that time period.
- [ ] TV Show Tracker
	- Got a favorite show you don’t want to miss? Don’t have a PVR or want to be able to find the show to then PVR it later? Make an application which can search various online TV Guide sites, locate the shows/times/channels and add them to a database application. The database/website then can send you email reminders that a show is about to start and which channel it will be on.
- [ ] Travel Planner System
	- Make a system that allows users to put together their own little travel itinerary and keep track of the airline / hotel arrangements, points of interest, budget and schedule. 
	
## Web
- [ ] E-Card Generator
	- Make a site that allows people to generate their own little e-cards and send them to other people. Do not use Flash. Use a picture library and perhaps insightful mottos or quotes.
- [ ] CAPTCHA Maker
	- Ever see those images with letters a numbers when you signup for a service and then asks you to enter what you see? It keeps web bots from automatically signing up and spamming. Try creating one yourself for online forms.
- [ ] Page scraper
	- Create an application which connects to a site and pulls out all links, or images, and saves them to a list. Optional: Organize the indexed content and don’t allow duplicates. Have it put the results into an easily searchable index file.

## Files
- [ ] Quiz Maker
	- Make an application which takes various questions form a file, picked randomly, and puts together a quiz for students. Each quiz can be different and then reads a key to grade the quizzes.
- [ ] RPG Character Stat Creator
	- Make a program which will randomly create a character’s stats based on several rules set forth by the user. Have it generate a class, gender, strength/magic/dexterity points, and extra abilities or trades. Have it save it to a file which can then be printed out by a dungeon master.

## Graphics and Multimedia
- [ ] Traffic Light Application
	- See if you can make your own street light application and then put it into an intersection scenario. Don’t let any cars run the lights and crash into one another!
- [ ] Signature Maker
	- Ever seen those web board posts where someone has a generated signature made up? See if you can make a program that allows the user to specify a background, text, colors and alignment to make their own signatures or userbars.
- [ ] Import Picture and Save as Grayscale
	- A utility that sucks the color right out of an image and saves it. You could add more including adjusting contrast, colorizing and more for added complexity.
- [ ] YouTube Downloader
	- A program which can download videos to your hard drive from youtube.com. Save the files in various formats including FLV and AVI.
- [ ] Screen Capture Program
	- Make a utility that will simply capture a frame from your web cam. For added complexity see if you can also build in emailing functionality.
- [ ] Watermarking Application
	- Have some pictures you want copyright protected? Add your own logo or text lightly across the background so that no one can simply steal your graphics off your site. Make a program that will add this watermark to the picture.
- [ ] Turtle Graphics
	- This is a common project where you create a floor of 20 x 20 squares. Using various commands you tell a turtle to draw a line on the floor. You have move forward, left or right, lift or drop pen etc. For added complexity, allow the program to read in the list of commands from a file. Do a search online for “Turtle Graphics” for more information.
	
## Games
- [ ] Battleship
	- Create two game boards and let each player place a number of war ships. Each player can’t see the other person’s board. They then take turns firing at one another by guessing one of the board squares. If the square they guess contains part of a ship, it is a hit. Otherwise it is a miss. They sink a ship when all squares containing that particular ship have been uncovered. The player wins when all their opponents’ ships have been sunk.
- [ ] Chess and Checkers
	- Simply put a game of chess or checkers. Try to make it playable online and if you can use a graphical user interface that can also undo or redo a step as well as keep a history of moves for replay.
- [ ] Hangman
	- Randomly select a word from a file, have the user guess characters in the word. For each character they guess that is not in the word, have it draw another part of a man hanging in a noose. If the picture is completed before they guess all the characters, they lose.
- [ ] Frogger
	- Get your frog across the river and lanes of traffic by either jumping on logs and lily pads rushing by at different speeds or avoid the automobiles which are also moving at various speeds. Based on the old arcade game..
- [ ] Text Based Game Like Utopia
	- Create a simple text based RPG like Utopia where you can create a civilization, gather resources, forge alliances, cast spells and more on a turn based system. See if you can dominate the kingdom.

## Security
- [ ] Ceasar Cipher
	- Implement a Caesar cipher, both encoding and decoding. The key is an integer from 1 to 25. This cipher rotates the letters of the alphabet (A to Z). The encoding replaces each letter with the 1st to 25th next letter in the alphabet (wrapping Z to A). So key 2 encrypts "HI" to "JK", but key 20 encrypts "HI" to "BC". This simple "monoalphabetic substitution cipher" provides almost no security, because an attacker who has the encoded message can either use frequency analysis to guess the key, or just try all 25 keys.
