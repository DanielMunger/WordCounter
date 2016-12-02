| Behavior                                                                                                                                                   | Input                                 | Output     |
|------------------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------|--------------|
| User enters a string of length one to find, and a matching sentence to be found in. Instances is returned.                                                 | Find: 'a' In: 'a'                     | Instances: 1 ~This test allows me to verify the inputs are being read correctly without performing any modifiers on them. |
| User enters a single word of identical characters, and a sentence with a matching word at the beginning of the sentence. Instances is returned             | Find: 'ccc' In: 'ccc ddd eee'         | Instances: 1 ~ This test allows me to verify that an inputted string of any length is able to be compared. |
| User enters a single word of identical characters and a sentence with a matching word anywhere in the sentence. Instances is returned.                     | Find: 'fff' In: 'abd fff crc'         | Instances: 1 ~ This test verifies that I am able to search anywhere in the inputted sentence to find a single instance of the inputted word.|
| User enters a single word of different characters, and a sentence with a matching word at the beginning of the sentence. Instances is returned.            | Find: 'the' In: 'the cat in a hat'    | Instances: 1 ~ This test allows me to check that a multiple character word is able to be found. Without this, my function would be rather useless. |
| User enters a single word of different characters, and a sentence with a matching word anywhere in the sentence. Instances is returned.                    | Find: 'the' In: 'a cat in the hat.'   | Instances: 1 ~ This test is the most important. It demonstrates that a word can be found anywhere in the sentence and counted. |
| User enters a single word of different characters, and a sentence with several matches anywhere in the sentence. Instances is returned.                    | Find: 'the' In: 'the cat in the hat.' | Instnaces: 2 ~ An extension of the previous test, this verifies that my method of finding a word returns all instances and not just a single instance. A key spec. |
| User enters a single word of different characters, and a sentence with several matches  anywhere in the sentence. Instances is returned, case-insensitive. | Find: 'The' In: 'thE cat in tHe hat.' | Instances: 2 ~ This test is unnecessary for the MVP but is a good fail-safe to make sure the user doesn't make any mistakes upon entry. |
| User enters a single word of different characters, and a sentence that includes punctuation and symbols. Instances is returned.          | Find: 'cat' In: 'The? Cat, in the hat! ' | Instances: 1 ~This test is necessary in order to make sure my program can handle any type of inputted text(that is within reason). |
# _{Word Counter}_

#### _{Counts instances of inputted word, returns integer value}, {12/2/2016}_

#### By _**{Daniel Munger}**_

## Description

_{This application is hosted on a local server and uses a form input to gather user information. The user inputs a word to search for in a given block of text and submits. The program takes the inputted information, modifies it slightly to ignore minor discrepancies, and uses a simple equality check to increment an instances variable. The user is then directed to another webpage that displays the returned instances variable. The program meets the defined specifications above.}_


## Setup/Installation Requirements

  * _Clone this program from my GitHub_
  * _Run 'dnu restore' to create a project.lock.json file_
  * _Run 'dnx kestrel' to start server_
  * _Open the webpage 'localhost:5004'_
  * _Follow website instructions_

## Known Bugs

_{There are no known bugs at this time.}_

## Technologies Used

_{Written in Atom in C#, complied using MicroSoft PowerShell}_

### License

*{ This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.}*

Copyright (c) 2016 **_{Daniel Munger}_**
