| Behavior                                      | Input                              | Output       |
|-----------------------------------------------|------------------------------------|--------------|
| User enters a string of length one to find,
and a matching sentence to be found in.
Instances is returned.                          | Find: 'a' In: 'a'                  | Instances: 1 |
| User enters a single word of identical characters, and a sentence with a matching word at the beginning of the sentence. Instances is returned  | Find: 'ccc' In: 'ccc ddd eee'      | Instances: 1 |
| User enters a single word of identical characters and a sentence with a matching word anywhere in the sentence. Instances is returned.          | Find: 'fff' In: 'abd fff crc'      | Instances: 1 |
| User enters a single word of different characters, and a sentence with a matching word at the beginning of the sentence. Instances is returned. | Find: 'the' In: 'the cat in a hat' | Instances: 1 |
