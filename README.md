# WTT
**Windows Tweaker Tool**

a easy way to tweak windows and its security policies.

currently in development.

**IMPORTANT PLEASE READ**

there are a few issues with this program as for now.
these security tweaks are not safe because windows policy system uses special unique mutexes, these mutexes are hardcoded in this program and not anymore unique.

this grants a attacker to change the policy which have been set by this program, because the mutex is nog longer unique.

I haven't found a better solution to combat this, but it would be great if someone could sent me a PR.

note: it's my first project in C# so my conventions may are wrong :)
