# LBSLC
LatestBackSlengC
## Variables init
### Int
`int name;` - 4 byte;
`(2|8|16)int name;` - custom size;
`'int name` - unsigned int;
Example:
`2'int name` - unsigned short (2 byte integer);
### Float
`float name;` - 4 byte;
`8float name;` - 8 byte;
`8'float name;` - unsigned 8 byte;
### String
`str name;` - normal string;
### Boolean
`bool name;` - boolean;
### Enum
`enum name;` - enum;
Example:
`enum name {first, second};`
`print (name.first);`
### Const
`const int name;` - const variable;
### Initialization
`int name = 123;` - initialization;
## Examples