#!/usr/bin/env bash

cd "$(dirname "$0")" || exit 1

classpath_separator=":"
case "$(uname -s)" in
    MINGW*|MSYS*|CYGWIN*) classpath_separator=";" ;;
esac

java -cp "out${classpath_separator}lib/*${classpath_separator}resources" ru.bstu.itz221.dmitriev.lab2.Main
