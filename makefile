install:
  sudo cp stack.fs /usr/share/gforth/0.7.3/stack.fs
  sudo cp cstr.fs /usr/share/gforth/0.7.3/cstr.fs
  sudo cp cchar.fs /usr/share/gforth/0.7.3/cchar.fs
  
  gforth -e "include cstr.fs include cchar.fs bye"
  
remove:
  sudo rm /home/fluffy/.gforth/libcc-named/.libs/cstr.*
  sudo rm /home/fluffy/.gforth/libcc-named/.libs/cchar.*
  
  sudo rm /usr/share/gforth/0.7.3/cchar.fs
  sudo cp /usr/share/gforth/0.7.3/stack.fs
  
