# Episerver Tech Test

You have 1 hour to accomplish as much as possible. Bonus marks for SOLID development and unit-testing. Give some thought to how you would improve your solution for discussion after.

## Requirements:

 - Please create code to cover off the user story detailed below
 - Your code must compile and run without error

## User story: 

- As a *web-editor*, I can *drop a custom listing component onto a page* so that *I can showcase content relating to a pre-defined search term* 
- As a *web-editor*, I can *define a custom header and paragraph of text above the search results* so that *I can set the context around the component*

## Acceptance criteria

- The components displays search results relevant to the preset search term (where the page properties contains the search term)
- The search results include title (H1 header) and precis (paragraph text) of each page returned in the search
- The number of results are limited to the amount configured within the component
- Search results are ordered by published date in descending order

## Example scenario:
 - The web-editor wants to showcase blog entries within a sidebar panel on the site. She drops the component onto the site, configures it with 5 maximum results and a search-term of 'blog'. The component displays 5 entries matching 'blog' in the title.
 
## Testable criteria:
  - Good use of SOLID 
  - Episerver Find is not necessary
  - Bonus marks for unit tests
 
 ## Project info:
 
 Episerver admin credentials:
 Username: admin
 Password: Passw0rd!
 
 Zip up your code and send it on to your recruiter. 
