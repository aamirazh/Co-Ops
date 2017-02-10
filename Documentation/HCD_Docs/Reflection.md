# Co-Ops Gamified App Reflection

## Introduction

This was a 3-week project on developing a gamified productivity app. Gamification is essentially adding elements of gaming to tools and services that aren't games. So, for example, Starbucks scratch cards can be an instance of gamification, because it's designed to keep the user coming back to buy Starbucks drinks and it gives them a kind of "achievement" to reach.

For us, we wanted to gamify a productivity app. Similar to games like Habit RPG and Doable, our app was to be some kind of an app that helped the user stay productive while keeping them hooked by adding gamification elements.

## Design

#### Research and Brainstorming

We used a couple gamified apps as models to help us brainstorm:

* http://yukaichou.com/lifestyle-gamification/the-top-ten-gamified-productivity-apps/

* http://yukaichou.com/gamification-examples/top-10-gamification-examples-human-race/

We especially looked at apps like Habit RPG and Doable, Habit RPG specifically being an interesting implementation of gamification, where you do chores and errands for gold that you can spend on rewards you define (like watching a movie, buying a game, etc).

However, we also looked at other gamification that had more of a "social" aspect. Even something like the ALS Ice Bucket challenge can be viewed as Gamification, but socially. It makes users either donate money to funding ALS or dump a bucket on ice water on themselves, and spread the word to their friends. This was gamified because it forces the user to make a decision, contribute to social good or do something interesting (pour a bucket of ice water on themselves) and spread the word. It used the element of social interaction to make the process of spreading the word of ALS "fun" and almost like a "game" to brag to friends.

#### Final Design

Our design tried to combine both, in that it tried to help the user be productive and keep up with a schedule, but also involved social interaction and pressure. In a nutshell, we made a partner or group oriented skill-development app. Essentially, the user would decide to start a habit, so, for example, running. However, they would add a friend to develop the habit with them. The app would set goals and reminders for the habit, as well as give positive reinforcement by rewarding medals for consistency. At the same time, though, it would have a reliable method of negative reinforcement in terms of social pressure. So, instead of relying only on the user to tell the app they're reaching their goals, it would also rely on the partner. If the user and their partner decide to run at 8am one day, and the user flakes, the partner would tell the app and the app would document this as well as punish the user in-app, both humiliating the user in an app but also in real life with their partner.

#### Reflection

We were pretty happy with our design (to see the complete design, see our GDD doc), though in retrospect, it was a bit ambitious for such a small project. However, overall, we believed we were able to come across this idea because of good research and a background knowledge on methods of gamification. We combined several different ways of implementing gamification into an app that was unique.

## Plan and Schedule

#### Original Plan

After one week of research and planning, we had two weeks to develop. We had Unity downloaded and all, and so we didn't expect to spend much time setting up the environment and having a testing environment. So, our original plan was as followed:

* First week: Do all baseline work. Set up a testing environment, set up a login service with Google Play Services (for users to "log in" and connect their accounts to their friends'), make a basic app that involves a login screen and start screen and empty menu.

* Second week: Actually implement all features. Create a record-keeping system, where the user can make a "skill" to develop and we store how often they should practice, and save their progress and consistency. Finish app and implement a notification system where we notify them and their partner(s) during practice time.

#### Reflection

As we will describe in the next few sections, this plan was far too far-fetched to work. We overestimated how much we could get done in two weeks, especially considering how busy we were. Instead of starting off laying all the groundwork and trying to make everything (networks, login functionality, testing) perfect, we should have tried to get a basic demo up and running ASAP then extended that.

## Process

We did our development for an Android App in Unity, and integrated Google Play Services for login functionality. I believe we actually used the wrong tools in this case. Using Unity for our App development made it hard, because we had to do everything from scratch, when creating a basic menu shouldn't be too hard since it's all been done before. Essentially, creating any object, even just a screen, would have to be done from scratch, such that it was a real built virtual object, instead of a predetermined "menu" or "popup" object.

We should have used something else for simple App development that wouldn't take so long, so we could focus on gamifying the app instead of spending so much time laying the groundwork.

## Progress

Our plan failed pretty hard because we spent our whole two weeks trying to do what we set aside for only the first week. Integrating three things: Unity, Android app dev, and Google Play Services was harder than we thought, and there was a lot of permission-grabbing we had to do. A lot of times, logging in just wouldn't work and we wouldn't know why. Also, because we required logging in to a Google Play account, we were only able to test by exporting our .apk to an Android phone and testing it there, which was very inefficient.

We managed to successfully create the login system and a basic starting screen after a week and a half, but by that time, we didn't have much time to actually develop the interface.

Also, one huge problem we ran into was that we decided to use Unity for our app development, but Unity's app development is structured less for productivity, menu-ed apps, but more for actual mobile games that have their own universe. So creating a menu and even just a starting screen took surprisingly long.

Overall, we severely underestimated the time it would take to develop an app like this, and I think using Unity for app development was a mistake, because it made things much slower. In retrospect, we could have used an existing framework and then extended those to include our gamified features. Also, we shouldn't have been so stubborn about fully implementing everything. What would have been better was to create a skeleton, single-player app, then extend it to include multiplayer options, so that if we stopped short we could at least have something to show for ourselves. In our case, we had to stop short of what we wanted to do, but we only did backend, networking, and database things, so we had nothing to demo or show front-end wise.

Towards the end of the last week, we decided to scrap together what we could. We are now trying to at least make our app demo-able, as in create a kind of menu and screen system so that we can at least show how the app should flow. I don't think we will be able to get the data-saving and the notification system down, though. In addition to a basic skeleton app for demoing, we committed to writing this reflection to identify exactly what went wrong and what we could do better next time.

## Final Reflection

All in all, we weren't able to finish the app, or even make it save progress and notify users in a reliable enough way such that it can be testable. However, we will have at least some kind of app usage flow, to show what the app *should* look like, having some buttons and menus represent features that haven't been implemented yet. We are also writing this reflection to explain why we weren't able to finish and identify learning points.

##### Here are a few things we did well:

* We did our research on gamification, and understood exactly what gamification is (though it is a fluid term).

* In addition to doing good research, we applied our research to our design well. Our game idea was pretty solid and covered different techniques of gamification.

* We documented things well. We created a game design document, did notes on a few readings we did, and even wrote notes

##### Here are a few things we learned:

* Focus on getting a basic, single-player demo out first. Trying to create a foundation for multiplayer interaction, a login system, and a perfect testing environment ended up taking way too much time.

* Relatedly, focus on the core functionality and the gamification principles rather than the app development itself. Two weeks is obviously not enough to create a perfect app, so we should have focused more on the concept of creating a gamified productivity app, and being able to demo what that would look like, rather than spending so much time on the actual app development, and on actually trying to get it on the Google Play Store and approved and all.

* Do better research on what tools or frameworks to use. Though we did a lot of research, we mostly did research on the gamified apps other people created, and less on how they created it. We also didn't do adequate research on mobile/Android app development, so we went into it blind. And then we decided to use Unity just because we were familiar with the name, and ended up realizing too late that what Unity mobile development was for didn't really fit what we wanted to do.

* Plan things out better, and give some buffer time, since things end up taking way longer than we plan, all the time. This means not just to estimate goals and setting time better, but also to prioritize things better. So, focus on creating a skeleton app first, then extending it, so that if we fall behind, we at least can show our progress. We kind of went into this thinking our app was too "professional" than it was. In reality, it was supposed to be a small, concept-oriented project, that we only developed over 2 weeks. And so if we treated it like that, we could have at least focused on basic implementation and front end for concept communication, then built more basis. Instead, we spent almost the whole 2 weeks just setting things up.

Basically, we did well with our research, documentation, and design. But the actual implementation was not very well-planned, and we didn't implement things very well or use the right frameworks to do so.

## Conclusion

Hence, this project was a great learning experience, but overall a slight failure. We didn't get to finish the app and are trying to scrap together as much as we can now. It is unfortunate because we were pretty happy with the concept, and we wish we got a chance to put it into testing. But, we decided we wanted to move on to the next project more than we wanted to finish this one. We did get enough out of this, though we ended up getting more ideological things down (what is gamification, how to brainstorm an idea for a game, and how to create an app/game design) rather than things that have to do with the actual game process.

However, we did learn a lot about the process of creating small game projects, as well as a lot about Unity development and Android app development. But, next time, instead of focusing on the frameworks, and the groundwork, we want to focus more on the actual gamifying of a game, and on the actual concept or idea we are trying to express, rather than the technology of how we will express it.
