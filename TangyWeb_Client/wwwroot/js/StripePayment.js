function redirectToCheckout(sessionId) {
    var stripe = Stripe('pk_test_51KrbenJRhmwEZpcKTFrgEl7cV049spQZZRoGKgR3MEvbXjRHjMBhChvds7lJusWt6PGDFl8ONqpDaR5jU2Eb5Wg200qhmcwFLt');
    stripe.redirectToCheckout({ sessionId: sessionId });
}