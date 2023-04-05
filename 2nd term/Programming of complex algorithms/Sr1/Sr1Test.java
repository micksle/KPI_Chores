import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class Sr1Test {

    @Test
    void count1() {
        double actual = Sr1.count(-6.8);
        double expected = 100.640;
        assertEquals(expected, actual);
    }

    @Test
    void count2() {
        double actual = Sr1.count(-2.2);
        double expected = -8.6;
        assertEquals(expected, actual);
    }

    @Test
    void count3() {
        double actual = Sr1.count(3);
        double expected = -1;
        assertEquals(expected, actual);
    }

    @Test
    void count4() {
        double actual = Sr1.count(18.7);
        double expected = -16.7;
        assertEquals(expected, actual);
    }

    @Test
    void count5() {
        double actual = Sr1.count(-23.1);
        double expected = 718.410;
        assertEquals(expected, actual);
    }
}