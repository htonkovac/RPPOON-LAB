#!/bin/bash
rm main.exe
mcs src/* -out:main.exe && \
mono main.exe
