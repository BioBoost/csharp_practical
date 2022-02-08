# Kings of Nothing

Kings of Nothing is the start of a small text adventure game where players can fight monsters and even each other.

To represent a player in game, a class has already been created called `Player`. However, most of its functionality is still missing. To take the game to the next level, it should at least be possible to move the `Player` and allow it to take damage and heal.

To realize this, the `Player` class should implement the following functionality:

* `Move(int deltaX, int deltaY)`: change the players current location with the given delta-values. `deltaX` and `deltaY` can be negative but no special attention should be given to this.
* `Damage(int damage)`: damage the player and lower its `health` with given amount of `damage`. Take note the players `health` should not go below `0`.
* `IsAlive(): bool`: indicate if a player is still alive. A player is considered alive as long as its health is greater than `0`.
* `Heal(int amount)`: increase the players `health` if its still alive. A dead player cannot be healed. Also make sure that the health of the player does not become greater than `100`.

The `Main()` method already contains a small demo application. Feel free to change it to your liking.

## Expected Output

```text
Kings of Noodles - Player bashing 101

Current player health: 100

Beating the player with 24 damage.
Current player health: 76

Healing the player with 20 health.
Current player health: 96

Healing the player again with 20 health.
Current player health: 100

Beating the player to death.
Current player health: 0
Is player alive? False

Moving the player with (12, 10).
 > Player x-coordinate: 12
 > Player y-coordinate: 10

Moving the player with (5, 8).
 > Player x-coordinate: 17
 > Player y-coordinate: 18
```

## Unit Tests

This project has accompanying unit tests. See [xUnit Tests](/README.md#xunit-tests) on how to run them.
