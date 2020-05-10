#!/bin/bash
rm main.exe 2> /dev/null
mcs src/* -out:main.exe && \
mono main.exe
