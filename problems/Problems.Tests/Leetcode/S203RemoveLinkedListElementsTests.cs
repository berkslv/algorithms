using Problems.Leetcode;

namespace Problems.Tests.Leetcode;

public class S203RemoveLinkedListElementsTests
    {
        private readonly S203RemoveLinkedListElements _solution = new S203RemoveLinkedListElements();

        [Fact]
        public void RemoveElements_EmptyList_ReturnsEmptyList()
        {
            // Arrange
            S203RemoveLinkedListElements.ListNode head = null;
            int val = 6;

            // Act
            var result = _solution.RemoveElements(head, val);

            // Assert
            Assert.Null(result); // An empty list should return null.
        }

        [Fact]
        public void RemoveElements_NoMatchingValues_ReturnsSameList()
        {
            // Arrange
            var head = new S203RemoveLinkedListElements.ListNode(1); // List: [1, 2, 3]
            head.next = new S203RemoveLinkedListElements.ListNode(2);
            head.next.next = new S203RemoveLinkedListElements.ListNode(3);
            int val = 6;

            // Act
            var result = _solution.RemoveElements(head, val);

            // Assert
            Assert.NotNull(result); // The result should not be null.
            Assert.Equal(1, result.val); // The first node should be 1.
            Assert.Equal(2, result.next.val); // The second node should be 2.
            Assert.Equal(3, result.next.next.val); // The third node should be 3.
            Assert.Null(result.next.next.next); // There should be no fourth node.
        }

        [Fact]
        public void RemoveElements_AllMatchingValues_ReturnsEmptyList()
        {
            // Arrange
            var head = new S203RemoveLinkedListElements.ListNode(7); // List: [7, 7, 7, 7]
            head.next = new S203RemoveLinkedListElements.ListNode(7);
            head.next.next = new S203RemoveLinkedListElements.ListNode(7);
            head.next.next.next = new S203RemoveLinkedListElements.ListNode(7);
            int val = 7;

            // Act
            var result = _solution.RemoveElements(head, val);

            // Assert
            Assert.Null(result); // The result should be null because all nodes were removed.
        }

        [Fact]
        public void RemoveElements_SomeMatchingValues_ReturnsListWithoutMatchingValues()
        {
            // Arrange
            var head = new S203RemoveLinkedListElements.ListNode(1); // List: [1, 2, 6, 3, 4, 5, 6]
            head.next = new S203RemoveLinkedListElements.ListNode(2);
            head.next.next = new S203RemoveLinkedListElements.ListNode(6);
            head.next.next.next = new S203RemoveLinkedListElements.ListNode(3);
            head.next.next.next.next = new S203RemoveLinkedListElements.ListNode(4);
            head.next.next.next.next.next = new S203RemoveLinkedListElements.ListNode(5);
            head.next.next.next.next.next.next = new S203RemoveLinkedListElements.ListNode(6);
            int val = 6;

            // Act
            var result = _solution.RemoveElements(head, val);

            // Assert
            Assert.NotNull(result); // The result should not be null.
            Assert.Equal(1, result.val); // The first node should be 1.
            Assert.Equal(2, result.next.val); // The second node should be 2.
            Assert.Equal(3, result.next.next.val); // The third node should be 3.
            Assert.Equal(4, result.next.next.next.val); // The fourth node should be 4.
            Assert.Equal(5, result.next.next.next.next.val); // The fifth node should be 5.
            Assert.Null(result.next.next.next.next.next); // There should be no sixth node.
        }

        [Fact]
        public void RemoveElements_MatchingValueAtHead_ReturnsListWithoutMatchingHead()
        {
            // Arrange
            var head = new S203RemoveLinkedListElements.ListNode(6); // List: [6, 1, 2, 3]
            head.next = new S203RemoveLinkedListElements.ListNode(1);
            head.next.next = new S203RemoveLinkedListElements.ListNode(2);
            head.next.next.next = new S203RemoveLinkedListElements.ListNode(3);
            int val = 6;

            // Act
            var result = _solution.RemoveElements(head, val);

            // Assert
            Assert.NotNull(result); // The result should not be null.
            Assert.Equal(1, result.val); // The first node should be 1.
            Assert.Equal(2, result.next.val); // The second node should be 2.
            Assert.Equal(3, result.next.next.val); // The third node should be 3.
            Assert.Null(result.next.next.next); // There should be no fourth node.
        }

        [Fact]
        public void RemoveElements_MatchingValueAtTail_ReturnsListWithoutMatchingTail()
        {
            // Arrange
            var head = new S203RemoveLinkedListElements.ListNode(1); // List: [1, 2, 3, 6]
            head.next = new S203RemoveLinkedListElements.ListNode(2);
            head.next.next = new S203RemoveLinkedListElements.ListNode(3);
            head.next.next.next = new S203RemoveLinkedListElements.ListNode(6);
            int val = 6;

            // Act
            var result = _solution.RemoveElements(head, val);

            // Assert
            Assert.NotNull(result); // The result should not be null.
            Assert.Equal(1, result.val); // The first node should be 1.
            Assert.Equal(2, result.next.val); // The second node should be 2.
            Assert.Equal(3, result.next.next.val); // The third node should be 3.
            Assert.Null(result.next.next.next); // There should be no fourth node.
        }

        [Fact]
        public void RemoveElements_MultipleMatchingValues_ReturnsListWithoutMatchingValues()
        {
            // Arrange
            var head = new S203RemoveLinkedListElements.ListNode(1); // List: [1, 2, 2, 3, 2, 4, 2]
            head.next = new S203RemoveLinkedListElements.ListNode(2);
            head.next.next = new S203RemoveLinkedListElements.ListNode(2);
            head.next.next.next = new S203RemoveLinkedListElements.ListNode(3);
            head.next.next.next.next = new S203RemoveLinkedListElements.ListNode(2);
            head.next.next.next.next.next = new S203RemoveLinkedListElements.ListNode(4);
            head.next.next.next.next.next.next = new S203RemoveLinkedListElements.ListNode(2);
            int val = 2;

            // Act
            var result = _solution.RemoveElements(head, val);

            // Assert
            Assert.NotNull(result); // The result should not be null.
            Assert.Equal(1, result.val); // The first node should be 1.
            Assert.Equal(3, result.next.val); // The second node should be 3.
            Assert.Equal(4, result.next.next.val); // The third node should be 4.
            Assert.Null(result.next.next.next); // There should be no fourth node.
        }
    }