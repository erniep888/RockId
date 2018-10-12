# RockId QARP #

## What is QARP ##

QARP stands for the **Q**uestion, **A**nswer, and **R**esult **P**rocess that is used to identify a rock specimen. 

## Problems To Be Solved ##

- Given a question, what are possible answers?
- Given an answer, what was the previous question?
- Given a question, what the previous question?
- Given and answer, what is the next question?

## Solution ##

The solution is a tree data structure whose nodes can be either a question or an answer.  An answer node is a terminating node while a question node will have one or more child nodes.  The table structure is as follows:

**QARP Table**
*ID*
*PARENT_ID*  - necessary to allow back navigation
*IS_QUESTION*  - necessary to allow application to seek child answers
*DISPLAY_TEXT*  - contains the question or answer
*DISPLAY_ORDER*  - necessary to group child answers in a specific order 
*ROCK_TYPE_ID* - the id of the rock type stored in the **ROCK_TYPES** table.

The application finds child answers by searching the table where the *PARENT_ID* matches the current question *ID*.  The child answers are display in the *DISPLAY_ORDER*.

The application knows a rock has been identified when it reaches a row that has *IS_QUESTION* set to false and a *ROCK_TYPE_ID* that is not null.