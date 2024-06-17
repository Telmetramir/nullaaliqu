void UpdateFallSpeed(float delta)
{
    float height = GetComponent<Rigidbody>().position.y;
    float velocity = GetComponent<Rigidbody>().velocity.y;

    float newVelocity = velocity + gravity * delta;

    GetComponent<Rigidbody>().velocity = new Vector3(0, newVelocity, 0);
}